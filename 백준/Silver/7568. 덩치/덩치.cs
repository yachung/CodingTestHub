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

        (int, int)[] peoples = new (int, int)[T];
        for (int i = 0; i < T; ++i)
        {
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int a = arr[0];
            int b = arr[1];

            peoples[i] = (a, b);
        }

        foreach (var i in peoples)
        {
            int rank = 1;
            foreach (var j in peoples)
            {
                if (j == i) continue;
                if (Compare(i, j) == -1) rank++;
            }
                
            sb.Append($"{rank} ");
        }

            sw.WriteLine(sb);

        sr.Close();
        sw.Close();
    }

    static public int Compare((int, int) A, (int, int) B)
    {
        if (A.Item1 > B.Item1 && A.Item2 > B.Item2) return 1;
        else if (A.Item1 < B.Item1 && A.Item2 < B.Item2) return -1;
        else return 0;
    }
}