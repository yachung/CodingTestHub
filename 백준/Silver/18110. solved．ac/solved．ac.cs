using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int outlier;
        double trimAvg = 0;

        if (input != 0)
        {
            int[] rateArr = new int[input];

            for (int i = 0; i < input; ++i)
                rateArr[i] = int.Parse(Console.ReadLine());

            Array.Sort(rateArr);

            outlier = CustomRound(rateArr.Length * 0.15);

            for (int i = outlier; i < rateArr.Length - outlier; ++i)
                trimAvg += rateArr[i];

            trimAvg = CustomRound(trimAvg / (rateArr.Length - 2 * outlier));
        }

        Console.WriteLine(trimAvg);
    }

    static int CustomRound(double num)
    {
        int value = (int)num;

        num = num - value;

        if (num < 0.5)
            return value;
        else
            return ++value;
    }
}