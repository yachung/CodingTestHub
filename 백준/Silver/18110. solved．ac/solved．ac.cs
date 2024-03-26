using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        if (input == 0)
            Console.WriteLine(0);
        else
        {
            int outlier;
            double trimAvg = 0;
            int[] rateArr = new int[input];

            for (int i = 0; i < input; ++i)
                rateArr[i] = int.Parse(Console.ReadLine());

            Array.Sort(rateArr);

            outlier = CustomRound(rateArr.Length * 0.15f);

            for (int i = outlier; i < rateArr.Length - outlier; ++i)
                trimAvg += rateArr[i];

            trimAvg = CustomRound(trimAvg / (rateArr.Length - 2 * outlier));

            Console.WriteLine(trimAvg);
        }
    }

    static int CustomRound(double num)
    {
        return (num - (int)num) < 0.5f ? (int)num : (int)num + 1;
    }
}