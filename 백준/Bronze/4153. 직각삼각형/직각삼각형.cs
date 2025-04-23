using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string endOfLine = "0 0 0";
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == endOfLine)
                    break;

                int[] arr = Array.ConvertAll(input.Split(), int.Parse);
                Array.Sort(arr);

                if (arr[2] * arr[2] == (arr[0] * arr[0] + arr[1] * arr[1]))
                    sb.AppendLine("right");
                else
                    sb.AppendLine("wrong");
            }

            Console.WriteLine(sb);
        }
    }
}
