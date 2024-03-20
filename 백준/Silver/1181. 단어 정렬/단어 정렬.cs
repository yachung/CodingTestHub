using System;
using System.Collections.Generic;

namespace DailyCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Solution(input);
        }

        public static void Solution(int input)
        {
            List<string> strList = new List<string>();

            for (int i = 0; i < input; ++i)
            {
                string word = Console.ReadLine();
                if (!strList.Contains(word))
                    strList.Add(word);
            }

            strList.Sort((string x, string y) =>
            {
                int ret = 0;

                if (ret == 0)
                {
                    ret = x.Length.CompareTo(y.Length);
                }

                if (ret == 0)
                {
                    ret = x.CompareTo(y);
                }

                return ret;
            });

            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
