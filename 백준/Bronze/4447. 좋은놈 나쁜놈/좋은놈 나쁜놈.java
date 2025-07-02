import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

public class Main {

    public static void main(String[] args) throws IOException {
        StringBuilder sb = new StringBuilder();
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(br.readLine());
        int countG;
        int countB;

        while (n-- > 0) {
            String input = br.readLine();
            sb.append(input);
            sb.append(" is ");

            countG = 0;
            countB = 0;

            for (var alphabet : input.toCharArray()) {
                if (alphabet == 'g' || alphabet == 'G')
                    countG++;
                else if (alphabet == 'b' || alphabet == 'B')
                    countB++;
            }

            if (countG > countB)
                sb.append("GOOD\n");
            else if (countG < countB)
                sb.append("A BADDY\n");
            else
                sb.append("NEUTRAL\n");
        }

        System.out.print(sb);
    }
}