using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());

        int[][] coordArr = new int[input][];
        for (int i = 0; i < input; ++i)
        {
            int[] tmp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            coordArr[i] = tmp;
        }

        Array.Sort(coordArr, (a, b) =>
        {
            if (a[0] == b[0])
                return a[1].CompareTo(b[1]);
            else
                return a[0].CompareTo(b[0]);
        });

        foreach (var item in coordArr)
            sb.AppendLine($"{item[0]} {item[1]}");

        Console.WriteLine(sb);
    }
}