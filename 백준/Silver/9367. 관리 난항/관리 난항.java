import java.io.*;
import java.util.*;

public class Main {

    public static class CarType {
        String name;
        int price;
        int deposit;
        int feePerKm;

        public CarType(String name, int price, int feePerKm, int deposit) {
            this.name = name;
            this.price = price;
            this.deposit = deposit;
            this.feePerKm = feePerKm;
        }
    }

    public static class IssueLog {
        String personName;
        String carName = null;
        int startTime = -1;
        int returnTime = -1;
        int accidentTime = -1;
        int distance = 0;
        int totalFee = 0;
        int breakageRate = 0;
        boolean isValidate = true;
        boolean isRenting = false;

        public void Init() {
            startTime = -1;
            returnTime = -1;
            accidentTime = 0;
            distance = 0;
            breakageRate = 0;
        }

        public int getTotalFee() {
            return totalFee;
        }

        public String getPersonName() {
            return personName;
        }

        public int getStartTime() {
            return startTime;
        }

        public void setStartTime(int startTime) {
            this.startTime = startTime;
        }

        public int getReturnTime() {
            return returnTime;
        }

        public void setReturnTime(int returnTime) {
            this.returnTime = returnTime;
        }

        public int getAccidentTime() {
            return accidentTime;
        }

        public void setAccidentTime(int accidentTime) {
            this.accidentTime = accidentTime;
        }

        public int getDistance() {
            return distance;
        }

        public void setDistance(int distance) {
            this.distance = distance;
        }

        public int getBreakageRate() {
            return breakageRate;
        }

        public void setBreakageRate(int breakageRate) {
            this.breakageRate = breakageRate;
        }

        public IssueLog(String personName) {
            this.personName = personName;
        }

        public String GetName() {
            return this.carName;
        }

        public void SetName(String carName) {
            this.carName = carName;
        }

        public void SetValidate(boolean validate) {
            this.isValidate = validate;
        }

        public int calculateRentalFee(CarType carType) {
            int fee = carType.deposit;
            fee += carType.feePerKm * distance; // 주행요금(k) * 거리
            return fee;
        }

        public int calculateAccidentFee(CarType carType)
        {
            return (int) Math.ceil(carType.price * breakageRate * 0.01f);
        }
    }

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int T = Integer.parseInt(br.readLine());
        StringTokenizer st;

        Map<String, CarType> carTypes = new HashMap<>();
        TreeMap<String, IssueLog> issueLogs = new TreeMap<>();

        for (int j = 0; j < T; ++j) {
            st = new StringTokenizer(br.readLine());
            int n = Integer.parseInt(st.nextToken());
            int m = Integer.parseInt(st.nextToken());

            carTypes.clear();
            issueLogs.clear();

            for (int i = 0; i < n; i++) {
                st = new StringTokenizer(br.readLine());
                String N = st.nextToken();
                int p = Integer.parseInt(st.nextToken());
                int q = Integer.parseInt(st.nextToken());
                int k = Integer.parseInt(st.nextToken());

                carTypes.put(N, new CarType(N, p, k, q));
            }

            for (int i = 0; i < m; i++) {
                st = new StringTokenizer(br.readLine());
                int t = Integer.parseInt(st.nextToken());
                String S = st.nextToken();
                char e = st.nextToken().charAt(0);

                if (!issueLogs.containsKey(S))
                    issueLogs.put(S, new IssueLog(S));

                IssueLog currentLog = issueLogs.get(S);

                if (!currentLog.isValidate)
                    continue;

                switch (e) {
                    case 'p':
                        if (currentLog.isRenting)
                            currentLog.SetValidate(false);
                        else {
                            currentLog.isRenting = true;
                            currentLog.setStartTime(t);
                            currentLog.SetName(st.nextToken());
                        }
                        break;
                    case 'r':
                        if (!currentLog.isRenting || currentLog.getStartTime() > t)
                            currentLog.SetValidate(false);
                        else {
                            currentLog.setReturnTime(t);
                            currentLog.setDistance(Integer.parseInt(st.nextToken()));
                            currentLog.totalFee += currentLog.calculateRentalFee(carTypes.get(currentLog.GetName()));
                            currentLog.isRenting = false;
                            currentLog.Init();
                        }
                        break;
                    case 'a':
                        if (!currentLog.isRenting)
                            currentLog.SetValidate(false);
                        else {
                            currentLog.setAccidentTime(t);
                            currentLog.setBreakageRate(Integer.parseInt(st.nextToken()));
                            currentLog.totalFee += currentLog.calculateAccidentFee(carTypes.get(currentLog.GetName()));
                        }
                        break;
                }
            }

            for (var issueLog : issueLogs.values()) {
                if (issueLog.isValidate && !issueLog.isRenting) {
                    sb.append(issueLog.getPersonName()).append(" ").append(issueLog.getTotalFee());
                } else
                    sb.append(issueLog.getPersonName()).append(" INCONSISTENT");

                sb.append("\n");
            }
        }

        System.out.println(sb);
        br.close();
    }
}
