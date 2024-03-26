using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        if (input == 1)
            Console.WriteLine(1);
        else
        {
            int value = (int)Math.Ceiling((input - 1) / 6f);
            int answer = 0;

            int cnt = 1;
            while (value > answer)
            {
                answer += cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}