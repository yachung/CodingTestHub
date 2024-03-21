using System;

namespace DailyCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] primeNums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int count = 0;
            bool flag = true;

            foreach (var item in primeNums)
            {
                if (item == 1) flag = false;
                else flag = true;

                for (int i = 2; i <= item / 2; ++i)
                {
                    if (item % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) count++;
            }

            Console.WriteLine(count);
        }
    }
}