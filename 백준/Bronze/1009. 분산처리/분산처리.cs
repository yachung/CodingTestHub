using System;
using System.Text;

public class Solution
{
    static void Main(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        var sb = new StringBuilder();

        int T = int.Parse(sr.ReadLine());
        for (int i = 0; i < T; ++i)
        {
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int a = arr[0];
            int b = arr[1];

            int value = 1;
            for (int j = 0; j < b; ++j)
            {
                value *= a;
                value %= 10;
            }

            sb.AppendLine(value == 0 ? "10" : value.ToString());
        }

        sw.WriteLine(sb);

        sr.Close();
        sw.Close();
    }
}