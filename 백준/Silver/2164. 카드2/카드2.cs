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
            LinkedList<int> cardList = new LinkedList<int>();

            for (int i = 0; i < input; ++i)
            {
                cardList.AddLast(i + 1);
            }

            while (cardList.Count > 1)
            {
                cardList.RemoveFirst();

                int tmp = cardList.First.Value;

                cardList.RemoveFirst();

                cardList.AddLast(tmp);
            }

            Console.WriteLine(cardList.First.Value);
        }
    }
}