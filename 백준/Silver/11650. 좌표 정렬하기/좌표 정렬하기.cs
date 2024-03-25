using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());

        string[] coordArr = new string[input];
        for (int i = 0; i < input; ++i)
            coordArr[i] = Console.ReadLine();

        Array.Sort(coordArr, (a, b) =>
        {
            int[] x = Array.ConvertAll(a.Split(), int.Parse);
            int[] y = Array.ConvertAll(b.Split(), int.Parse);

            int ret = 0;

            if (ret == 0)
                ret = x[0].CompareTo(y[0]);

            if (ret == 0)
                ret = x[1].CompareTo(y[1]);


            return ret;
        });

        foreach (var item in coordArr)
            sb.AppendLine(item);

        Console.WriteLine(sb);
    }

}