using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] drawTimes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] realTimes = new int[input];

        Array.Sort(drawTimes);

        int minValue = 0;

        realTimes[0] = drawTimes[0];

        for (int i = 1; i < input; ++i)
            realTimes[i] = drawTimes[i] + realTimes[i - 1];

        foreach (var time in realTimes)
            minValue += time;

        Console.WriteLine(minValue);
    }
}