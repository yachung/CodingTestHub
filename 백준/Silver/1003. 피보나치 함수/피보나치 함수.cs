using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());
        int[] inputArr = new int[input];

        int max = -1;

        for (int i = 0; i < input; ++i)
        {
            inputArr[i] = int.Parse(Console.ReadLine());

            if (inputArr[i] > max)
                max = inputArr[i];
        }

        (int, int)[] fiboArr = new (int, int)[max + 1];

        fiboArr[0] = (1, 0);

        if (max > 0)
            fiboArr[1] = (0, 1);

        for (int i = 2; i <= max; ++i)
            fiboArr[i] = (fiboArr[i - 1].Item1 + fiboArr[i - 2].Item1, 
                fiboArr[i - 1].Item2 + fiboArr[i - 2].Item2);
        
        foreach (var value in inputArr)
            sb.Append($"{fiboArr[value].Item1} {fiboArr[value].Item2}\n");

        Console.WriteLine(sb);
    }
}