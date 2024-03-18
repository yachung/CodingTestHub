using System;
using System.Text;

namespace _24._03._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int[] arrNum = new int[inputNum];

            for (int i = 0; i < inputNum; ++i)
                arrNum[i] = int.Parse(Console.ReadLine());

            Array.Sort(arrNum);

            StringBuilder sb = new StringBuilder(string.Join("\n", arrNum));
            Console.WriteLine(sb);
        }
    }
}
