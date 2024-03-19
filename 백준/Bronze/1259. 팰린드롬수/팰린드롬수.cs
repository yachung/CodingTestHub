using System;

namespace DailyCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                    break;

                Solution(input);
            }

        }

        public static void Solution(int input)
        {
            string word = Convert.ToString(input);

            bool flag = true;
            for (int i = 0; i <= word.Length / 2; ++i)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
