using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());
        int[] coordArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        SortedSet<int> coordHash = new SortedSet<int>();
        Dictionary<int, int> coordDict = new Dictionary<int, int>();

        foreach (var coord in coordArr)
            coordHash.Add(coord);

        int idx = 0;
        foreach (var coord in coordHash)
            coordDict.Add(coord, idx++);

        foreach (var coord in coordArr)
            sb.Append($"{coordDict[coord]} ");

        Console.WriteLine(sb);
    }
}