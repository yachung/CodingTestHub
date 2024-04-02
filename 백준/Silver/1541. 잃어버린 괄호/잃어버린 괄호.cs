using System;

class Program
{
    static void Main()
    {
        string[] formula = Console.ReadLine().Split('-');

        int answer = 0;
        bool flag = true;

        foreach (var item in formula)
        {
            int value = 0;

            int[] numbers = Array.ConvertAll(item.Split('+'), int.Parse);
            foreach (var num in numbers)
                value += num;
            
            if (flag)
            {
                answer += value;
                flag = false;
            }
            else
                answer -= value;
        }

        Console.WriteLine(answer);
    }
}