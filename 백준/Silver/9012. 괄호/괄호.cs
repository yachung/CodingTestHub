using System;
using System.Text;


class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input; ++i)
        {
            string strVPS = Console.ReadLine();

            if (CheckVPS(strVPS))
                sb.AppendLine("YES");
            else
                sb.AppendLine("NO");
        }

        Console.WriteLine(sb.ToString());
    }

    static bool CheckVPS(string vps)
    {
        int count = 0;

        char defaultPS = '(';

        foreach (var ps in vps)
        {
            if (ps == defaultPS)
                count++;
            else
                count--;

            if (count < 0)
                break;
        }

        if (count == 0)
            return true;
        else
            return false;
    }
}