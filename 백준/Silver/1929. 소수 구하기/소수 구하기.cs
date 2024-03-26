using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = input[0]; i <= input[1]; ++i)
        {
            
            bool flag;

            if (i != 1) flag = true;
            else flag = false;
            
            for (int j = 2; j <= Math.Sqrt((double)i); ++j)
            {
                if (i % j == 0)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
                sb.Append($"{i}\n");
        }

        Console.WriteLine(sb);
    }
}