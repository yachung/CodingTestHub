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
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < input; ++i)
            {
                queue.Enqueue(i + 1);
            }

            while (queue.Count > 1)
            {
                queue.Dequeue();
                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine(queue.Dequeue());
        }
    }
}