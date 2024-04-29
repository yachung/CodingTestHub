using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        long factorial = N;
        int cnt = 0;

        while (--N > 0)
        {
            while (factorial % 10 == 0)
            {
                cnt++;
                factorial /= 10;
            }

            factorial *= N;
            factorial %= 10000;
        }

        Console.WriteLine(cnt);
    }
}