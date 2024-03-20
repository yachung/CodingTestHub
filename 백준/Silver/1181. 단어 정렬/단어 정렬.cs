using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                strList.Add(Console.ReadLine());

            strList = strList.Distinct().ToList();

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

            StringBuilder sb = new StringBuilder(string.Join("\n", strList));

            Console.WriteLine(sb);
        }
    }
}
