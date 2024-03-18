using System;

namespace _24._03._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(solution(input));
        }

        static public int solution(int x)
        {
            int answer = 0;

            int stick = 64;

            while (stick > x)
            {
                stick /= 2;
            }

            int sum = 0;

            while (true)
            {
                if (sum == x)
                    break;

                if (sum + stick <= x)
                {
                    sum += stick;
                    answer++;
                }

                stick /= 2;
            }

            return answer;
        }
    }
}
