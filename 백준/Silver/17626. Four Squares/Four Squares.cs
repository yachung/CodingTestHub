using System;
using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Function(n));
        }

        static int Function(int n)
        {
            int[] dp = new int[50001];
            dp[0] = 0;

            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j*j <= i; ++j)
                {
                    int value = dp[i - j * j] + 1;
                    if (dp[i] == 0)
                        dp[i] = value;
                    else if (dp[i] > value)
                        dp[i] = value;
                }
            }

            return dp[n];
        }
    }

}