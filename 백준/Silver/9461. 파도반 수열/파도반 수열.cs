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

        
        for (int i = 0; i < input; ++i)
            tcArr[i] = int.Parse(Console.ReadLine());

        // 1 <= tc <= 100 이라 배열이 int 면 tc가 100일때 오버플로우 발생.
        long[] tcSum = new long[101];

        // 디폴트 값 설정
        tcSum[1] = 1;
        tcSum[2] = 1;
        tcSum[3] = 1;
        tcSum[4] = 2;
        tcSum[5] = 2;

        for (int i = 6; i < tcSum.Length; ++i)
            tcSum[i] = tcSum[i - 1] + tcSum[i - 5];

        foreach (var item in tcArr)
            sb.Append(tcSum[item]).Append('\n');

        Console.WriteLine(sb);
    }
}
