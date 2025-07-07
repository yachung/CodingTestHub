import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import java.util.*;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        String[] inputs = br.readLine().split(" ");
        int N = Integer.parseInt(inputs[0]);
        int M = Integer.parseInt(inputs[1]);

        Map<Integer, String> poketmons1 = new HashMap<>();
        Map<String, Integer> poketmons2 = new HashMap<>();
        String input;
        for (int i = 0; i < N; i++) {
            input = br.readLine();
            poketmons1.put(i, input);
            poketmons2.put(input, i);
        }

        for (int i = 0; i < M; i++) {
            input = br.readLine();
            if (poketmons2.containsKey(input)) {
                sb.append(poketmons2.get(input) + 1);
            } else {
                sb.append(poketmons1.get(Integer.parseInt(input) - 1));
            }
            sb.append("\n");
        }

        System.out.println(sb);
    }
}
