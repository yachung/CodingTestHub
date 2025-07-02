import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import java.math.BigInteger;

public class Main {

    public static void main(String[] args) throws IOException {
        StringBuilder sb = new StringBuilder();
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        BigInteger N = new BigInteger(br.readLine());

        BigInteger root = binarySearch(N, BigInteger.ONE, N);

        System.out.println(root);
    }

    public static BigInteger binarySearch(BigInteger target, BigInteger start, BigInteger end)
    {
        BigInteger mid = start.add(end).divide(BigInteger.valueOf(2));

        BigInteger square = mid.multiply(mid);

        int result = square.compareTo(target);

        if (result > 0)
            return binarySearch(target, start, mid.subtract(BigInteger.ONE));
        else if (result < 0)
            return binarySearch(target, mid.add(BigInteger.ONE), end);
        else
            return mid;
    }
}
