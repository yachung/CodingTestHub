using System;
using System.Text;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int M = int.Parse(Console.ReadLine());
        int[] checkArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Dictionary<int, int> dicNum = new Dictionary<int, int>();

        StringBuilder sb = new StringBuilder();

        foreach (int num in numArray)
        {
            if (dicNum.ContainsKey(num))
                dicNum[num]++;
            else
                dicNum.Add(num, 1);
        }

        foreach (int num in checkArray)
        {
            if (!dicNum.ContainsKey(num))
                sb.Append("0 ");
            else
                sb.Append($"{dicNum[num]} ");
        }

        Console.WriteLine(sb.ToString());
    }
}