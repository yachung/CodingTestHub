using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            float[] arr = new float[N];
            arr = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);

            int minimum = 0;

            foreach (var count in arr)
            {
                if (count == 0)
                    continue;

                if (minimum == 0 && (count * 10) % 10 == 5)
                    minimum++;

                minimum += (int)count;
            }

            Console.WriteLine(minimum);
        }
    }
}
