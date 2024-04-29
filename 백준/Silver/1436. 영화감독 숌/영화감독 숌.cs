using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int count = 0;
        string strCount;
        while (true) 
        {
            count++;

            strCount = count.ToString();

            if (strCount.Contains("666"))
            {
                if (N == 1)
                    break;
                N--;
            }
        }

        Console.WriteLine(strCount);
    }
}