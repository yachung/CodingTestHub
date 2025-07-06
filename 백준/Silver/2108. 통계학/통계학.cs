using System.Text;

public class Solution
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int N = int.Parse(sr.ReadLine());

        int[] numbers = new int[N];

        for (int i = 0; i < N; i++) numbers[i] = int.Parse(sr.ReadLine());

        int sum = 0;
        foreach (var n in numbers) sum += n;
        double avg = numbers.Average();
        int mean = (int)(avg < 0 ? avg - 0.5 : avg + 0.5);

        sb.AppendLine(mean.ToString());

        Array.Sort(numbers);
        int median = numbers[N / 2];
        sb.AppendLine(median.ToString());

        // 3. 최빈값 (배열을 이용한 최적화)
        // 숫자의 범위가 -4000 ~ 4000이므로, 크기 8001의 배열로 빈도를 계산합니다.
        // 인덱스 0 ~ 8000은 숫자 -4000 ~ 4000에 해당합니다. (숫자 + 4000 = 인덱스)
        int[] counts = new int[8001];
        foreach (int num in numbers)
            counts[num + 4000]++;

        // 최대 빈도수 찾기
        int maxCount = counts.Max();

        // 최대 빈도수를 가진 숫자들 찾기
        var modes = new List<int>();
        for (int i = 0; i < 8001; i++)
        {
            if (counts[i] == maxCount)
                modes.Add(i - 4000); // 인덱스를 다시 원래 숫자로 변환
        }

        // modes 리스트는 인덱스 순서대로 추가되었으므로 이미 오름차순 정렬 상태입니다.
        // 최빈값이 여러 개이면 두 번째로 작은 값을, 아니면 첫 번째 값을 선택합니다.
        int mode = modes.Count > 1 ? modes[1] : modes[0];
        sb.AppendLine(mode.ToString());

        // 4. 범위
        // 정렬된 리스트에서 최댓값(마지막 원소)과 최솟값(첫 번째 원소)의 차이를 계산
        int range = numbers[N - 1] - numbers[0];
        sb.AppendLine(range.ToString());

        sw.WriteLine(sb.ToString());

        sw.Close();
    }
}