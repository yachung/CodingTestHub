using System.Text;

public class Solution
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; ++i)
        {
            string[] input = Console.ReadLine().Split();
            int count = int.Parse(input[0]);
            foreach (var item in input[1])
            {
                for (int j = 0; j < count; ++j)
                    sb.Append(item);
            }
            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }
}