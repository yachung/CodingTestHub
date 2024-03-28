using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] DP = new int[1000001];

        for (int i = 2; i <= input; ++i)
        {
            DP[i] = DP[i - 1] + 1;

            if (i % 3 == 0)
                DP[i] = Math.Min(DP[i], DP[i / 3] + 1);

            if (i % 2 == 0)
                DP[i] = Math.Min(DP[i], DP[i / 2] + 1);
        }
        
        Console.WriteLine(DP[input]);
    }
}