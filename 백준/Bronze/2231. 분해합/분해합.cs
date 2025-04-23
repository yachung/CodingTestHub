using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int maxDigit = 0;
            int M = N;
            while (M >= 1)
            {
                M /= 10;
                maxDigit++;
            }

            int value = N - maxDigit * 9;

            int result = 0;

            for (int i = value; i < N; ++i)
            {
                if (i < 0)
                    continue;

                string temp = i.ToString();
                int sum = 0;

                foreach (var num in temp)
                    sum += ((int)num - '0');

                if (i + sum == N)
                {
                    result = i;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
