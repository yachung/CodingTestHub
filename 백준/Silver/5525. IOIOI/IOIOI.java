import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder("I");

        int N = Integer.parseInt(br.readLine());
        int M = Integer.parseInt(br.readLine());
        String S = br.readLine();

        for (int i = 0; i < N; i++)
            sb.append("OI");

        String PN = sb.toString();
        int length = PN.length();
        int count = 0;
        for (int i = 0; i <= M - length; ++i)
            if (PN.equals(S.substring(i, i + length)))
                count++;

        System.out.println(count);
    }
}