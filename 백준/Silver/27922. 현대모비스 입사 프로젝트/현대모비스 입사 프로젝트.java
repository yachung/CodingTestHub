import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));

        StringBuilder sb = new StringBuilder();

        int[] inputs = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int N = inputs[0];
        int K = inputs[1];
        int[][] lectures = new int[N][3];

        for (int i = 0; i < N; i++) {
            lectures[i] = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        }
        // 1234, 2
        int[] arrSum01 = new int[N];
        int[] arrSum02 = new int[N];
        int[] arrSum12 = new int[N];
        for (int i = 0; i < N; i++) {
            arrSum01[i] = lectures[i][0] + lectures[i][1];
            arrSum02[i] = lectures[i][0] + lectures[i][2];
            arrSum12[i] = lectures[i][1] + lectures[i][2];
        }
        Arrays.sort(arrSum01);
        Arrays.sort(arrSum02);
        Arrays.sort(arrSum12);

        int sum01 = 0;
        for (int i = N-1; i >= N - K; i--)
            sum01 += arrSum01[i];
        int sum02 = 0;
        for (int i = N-1; i >= N - K; i--)
            sum02 += arrSum02[i];
        int sum12 = 0;
        for (int i = N-1; i >= N - K; i--)
            sum12 += arrSum12[i];

        int max = Math.max(Math.max(sum01, sum02), sum12);
        System.out.println(max);

        br.close();
        bw.close();
    }
}
