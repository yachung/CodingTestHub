import java.io.*;
import java.util.*;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        StringTokenizer st = new StringTokenizer(br.readLine());
        int N = Integer.parseInt(st.nextToken());
        int M = Integer.parseInt(st.nextToken());

        int[][] Table = new int[N][N];
        for (int i = 0; i < N; i++) {
            st = new StringTokenizer(br.readLine());
            for (int j = 0; j < N; j++)
                Table[i][j] = Integer.parseInt(st.nextToken());
        }

        int[][] sum = new int[N][N];
        for (int i = 0; i < N; i++) {
            sum[i][0] = Table[i][0];
            for (int j = 1; j < N; j++)
                sum[i][j] = sum[i][j-1] +Table[i][j];
        }

        for (int i = 0; i < M; i++) {
            st = new StringTokenizer(br.readLine());
            int x1 = Integer.parseInt(st.nextToken()) - 1;
            int y1 = Integer.parseInt(st.nextToken()) - 2;
            int x2 = Integer.parseInt(st.nextToken()) - 1;
            int y2 = Integer.parseInt(st.nextToken()) - 1;

            int sectionSum = 0;
            for (int j = x1; j <= x2; j++) {
                if (y1 >= 0)
                    sectionSum += (sum[j][y2] - sum[j][y1]);
                else
                    sectionSum += sum[j][y2];
            }
            sb.append(sectionSum).append("\n");
        }

        System.out.println(sb);
    }
}