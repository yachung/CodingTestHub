using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        HashSet<string> inputHash = new HashSet<string>();
        SortedSet<string> outputHash = new SortedSet<string>();


        for (int i = 0; i < inputArr[0]; ++i)
            inputHash.Add(Console.ReadLine());
        
        for (int i = 0; i < inputArr[1]; ++i)
        {
            string name = Console.ReadLine();
            if (inputHash.Contains(name))
                outputHash.Add(name);
        }


        sb.Append(outputHash.Count).Append('\n');

        foreach (var item in outputHash)
            sb.AppendLine(item);
        
        Console.WriteLine(sb);
    }
}