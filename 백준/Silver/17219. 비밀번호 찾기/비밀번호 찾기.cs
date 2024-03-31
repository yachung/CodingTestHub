using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int addrNum = inputArr[0];
        int findNum = inputArr[1];

        Dictionary<string, string> dicAddress = new Dictionary<string, string>();

        while (addrNum > 0)
        {
            string[] strArrd = Console.ReadLine().Split();

            dicAddress.Add(strArrd[0], strArrd[1]);

            addrNum--;
        }

        while (findNum > 0)
        {
            sb.AppendLine(dicAddress[Console.ReadLine()]);

            findNum--;
        }

        Console.WriteLine(sb);
    }
}