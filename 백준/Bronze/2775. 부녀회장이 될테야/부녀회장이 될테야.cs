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
        int[,] apart = new int[15,15];

        for (int i = 0; i <= 14; i++)
            apart[0, i] = i;

        while (T-- > 0)
        {
            int k = int.Parse(sr.ReadLine());
            int n = int.Parse(sr.ReadLine());

            if (apart[k,n] == 0)
            {
                for (int j = 1; j <= k; ++j)
                {
                    apart[j, 1] = 1;
                    for (int i = 2; i <= n; ++i)
                    {
                        apart[j, i] = apart[j, i - 1] + apart[j - 1, i];
                    }
                }
            }

            sb.AppendLine(apart[k, n].ToString());
        }

        sw.WriteLine(sb.ToString());

        sr.Close();
        sw.Close();
    }
}