using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();

        int K = int.Parse(input[0]);
        int N = int.Parse(input[1]);
        long count = 0;
        long start = 1;
        long end = 0;
        long mid = 0;

        int[] lines = new int[K];

        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = int.Parse(Console.ReadLine());
            end = lines[i] > end ? lines[i] : end;
        }

        while (start <= end)
        {
            mid = (start + end) / 2;
            count = 0;

            foreach (var line in lines)
                count += (line / mid);

            if (count < N)
                end = mid - 1;
            else
                start = mid + 1;
        }

        Console.WriteLine(end);
    }
}