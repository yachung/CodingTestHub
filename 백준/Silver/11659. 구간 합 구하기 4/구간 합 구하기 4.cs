using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int N = inputArr[0];
        int M = inputArr[1];
        int[] prefixSum = new int[N];

        prefixSum[0] = numbers[0];
        for (int i = 1; i < N; ++i)
        {
            prefixSum[i] = numbers[i] + prefixSum[i - 1];
        }

        while (M-- > 0)
        {
            int[] ranges = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int start = ranges[0] - 1;
            int end = ranges[1] - 1;

            int sum = 0;

            if (start == 0)
                sum = prefixSum[end];
            else
                sum = prefixSum[end] - prefixSum[start - 1];

            sb.Append(sum).Append('\n');
        }

        Console.WriteLine(sb);
    }
}