using System;

class Program
{
    static void Main(string[] args)
    {
        int S = int.Parse(Console.ReadLine());
        int[] scores = new int[S];
        int[] maxArr = new int[S];

        for (int i = 0; i < S; i++) scores[i] = int.Parse(Console.ReadLine());
        
        maxArr[0] = scores[0];
        
        if (S > 1)
            maxArr[1] = scores[0] + scores[1];
        if (S > 2)
            maxArr[2] = scores[0] > scores[1] ? scores[0] + scores[2] : scores[1] + scores[2];

        for (int i = 3; i < S; i++)
        {
            maxArr[i] = scores[i] + Math.Max(maxArr[i - 2], maxArr[i - 3] + scores[i - 1]);
        }

        Console.WriteLine(maxArr[S-1]);
    }
}