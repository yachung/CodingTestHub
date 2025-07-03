import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import java.util.Arrays;

public class Main {

    public static void main(String[] args) throws IOException {
        StringBuilder sb = new StringBuilder();
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int[] arrDwarf = new int[9];
        int sum = 0;

        for (int i = 0; i < arrDwarf.length; i++)
        {
            arrDwarf[i] = Integer.parseInt(br.readLine());
            sum += arrDwarf[i];
        }

        Arrays.sort(arrDwarf);

        int[] removeArr = findNotDwarf(sum, arrDwarf);

        boolean skip = false;
        for (int i = 0; i < arrDwarf.length; i++)
        {
            for (int remove : removeArr)
                if (remove == i)
                    skip = true;

            if (skip)
            {
                skip = false;
                continue;
            }

            sb.append(arrDwarf[i]).append("\n");
        }

        System.out.println(sb);
    }

    public static int[] findNotDwarf(int sum, int[] arr) {
        for (int i = 0; i < arr.length; i++)
        {
            int partialSum = 0;

            for (int j = i + 1; j < arr.length; j++)
            {
                partialSum = arr[i] + arr[j];

                if (sum - partialSum == 100)
                    return new int[]{i, j};
            }
        }

        return null;
    }
}
