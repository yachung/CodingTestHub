using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());
        
        HashSet<int> hash = new HashSet<int>();

        while (input > 0)
        {
            string[] operArr = Console.ReadLine().Split();

            string oper = operArr[0];
            int num = operArr.Length > 1 ? int.Parse(operArr[1]) : -1;

            switch (oper)
            {
                case "add":
                    hash.Add(num);
                    break;
                case "remove":
                    hash.Remove(num);       
                    break;
                case "check":
                    if (hash.Contains(num))
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                    break;
                case "toggle":
                    if (hash.Contains(num))
                        hash.Remove(num);
                    else
                        hash.Add(num);
                    break;
                case "all":
                    hash = new HashSet<int>()
                    {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
                    };
                    break;
                case "empty":
                    hash = new HashSet<int>();
                    break;
            }

            input--;
        }

        Console.WriteLine(sb);
    }
}