using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());
        int[] tcArr = new int[input];

        int max = 0;
        
        for (int i = 0; i < input; ++i)
        {
            tcArr[i] = int.Parse(Console.ReadLine());
            max = Math.Max(max, tcArr[i]);
        }


        int[] tcSum = new int[max + 1];

        tcSum[1] = 1;
        tcSum[2] = 2;
        tcSum[3] = 4;

        for (int i = 4; i < tcSum.Length; ++i)
            tcSum[i] = tcSum[i - 1] + tcSum[i - 2] + tcSum[i - 3];

        foreach (var item in tcArr)
            sb.Append(tcSum[item]).Append('\n');

        Console.WriteLine(sb);
    }
}