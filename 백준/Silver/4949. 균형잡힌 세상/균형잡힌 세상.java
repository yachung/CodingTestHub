import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import java.util.*;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        while (true) {
            String input = br.readLine();

            if (input.equals("."))
                break;

            sb.append(isBalance(input)).append("\n");
        }

        System.out.println(sb.toString());
    }

    public static String isBalance(String input) {
        Stack<Character> stack = new Stack<Character>();

        for (var item : input.toCharArray()) {
            if (item == ('(') || item == ('[')) {
                stack.push(item);
            } else if (item == (')')) {
                if (stack.isEmpty() || !stack.pop().equals('('))
                    return "no";
            } else if (item == (']')) {
                if (stack.isEmpty() || !stack.pop().equals('['))
                    return "no";
            }
        }

        if (stack.isEmpty())
            return "yes";
        else
            return "no";
    }
}
