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
        Stack<String> stack = new Stack<String>();

        for (String item : input.split("")) {
            if (item.equals("(") || item.equals("[")) {
                stack.push(item);
            } else if (item.equals(")")) {
                if (stack.isEmpty() || !stack.pop().equals("("))
                    return "no";
            } else if (item.equals("]")) {
                if (stack.isEmpty() || !stack.pop().equals("["))
                    return "no";
            }
        }

        if (stack.isEmpty())
            return "yes";
        else
            return "no";
    }
}
