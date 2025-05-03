using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[] trees = new int[N];
            trees = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(Function(trees, M));
        }

        static int BinarySearch(int[] arr, int target, int start, int end)
        {
            int result = 0;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                long sum = 0;
                foreach (var tree in arr)
                {
                    if (tree > mid)
                        sum += tree - mid;
                }

                if (sum >= target)
                {
                    start = mid + 1;
                    result = mid;
                }
                else
                    end = mid - 1;
            }

            return result;
        }

        static int Function(int[] arr, int target)
        {
            int maximum = int.MinValue;

            foreach (var tree in arr)
            {
                if (tree > maximum) maximum = tree;
            }

            return BinarySearch(arr, target, 0, maximum);
        }
    }
}