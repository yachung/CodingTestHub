using System;

class Program
{
    static void Main()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] coinArr = new int[input[0]];
        int target = input[1];
        int value = 0;

        int minValue = 0;

        for (int i = 0; i < input[0]; ++i)
            coinArr[i] = int.Parse(Console.ReadLine());

        for (int i = coinArr.Length - 1; i >= 0; --i)
        {
            int num = target / coinArr[i];
            if (num > 0)
            {
                minValue += num;
                value += num * coinArr[i];
                target -= num * coinArr[i];
            }

            if (target == 0)
                break;
        }

        Console.WriteLine(minValue);
    }
}