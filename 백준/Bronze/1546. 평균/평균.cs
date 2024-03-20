using System;

namespace DailyCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            string[] arr = Console.ReadLine().Split();

            int max = 0;
            float answer = 0;
            for (int i = 0; i < input; ++i)
            {
                int num = int.Parse(arr[i]);
                if (num > max)
                    max = num;
            }

            foreach (var item in arr)
            {
                float value = (float.Parse(item) / max) * 100;
                answer += value;
            }

            Console.WriteLine(answer / input);

        }
    }
}