import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import java.util.StringTokenizer;

public class Main {

	public static void main(String[] args) throws IOException {
		int C;
		boolean isTimeOut;
		StringBuilder sb = new StringBuilder();

		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		StringTokenizer st;
		C = Integer.parseInt(br.readLine());

		while (C-- > 0)
		{
			st = new StringTokenizer(br.readLine());
			String bigO = st.nextToken();
			// 최대 범위
			int N = Integer.parseInt(st.nextToken());
			// 테스트 케이스 개수
			int T = Integer.parseInt(st.nextToken());
			// 제한 시간 단위
			int L = Integer.parseInt(st.nextToken());
			
			isTimeOut = TimeOutCheck(bigO, N, T, L);
			
			if (isTimeOut)
				sb.append("TLE!");
			else
				sb.append("May Pass.");
			
			sb.append("\n");
		}
		
		System.out.println(sb);
	}
	
	public static boolean TimeOutCheck(String bigO, long N, int T, int L)
	{
		long time = L * 100000000L / T;
		long value = 1;

		switch (bigO)
		{
			case "O(N)":
				return N > time;
			case "O(N^2)":
				return N > Math.sqrt(time);
			case "O(N^3)":
				return N > Math.cbrt(time);
			case "O(2^N)":
				for (int i = 0; i < N; i++)
				{
					value *= 2;
					if (value > time)
						return true;
				}
                break;
			case "O(N!)":
				for (long i = N; i > 0; i--)
				{
					value *= i;
					if (value > time)
						return true;
				}
                break;
		}
		
		return false;
	}
}