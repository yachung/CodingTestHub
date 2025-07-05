using System;
using System.Text;

public class Solution
{
    static void Main(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int result = 0;

        int N = int.Parse(sr.ReadLine());

        Stack<int> stack = new Stack<int>();
        while (N-- > 0)
        {
            int num = int.Parse(sr.ReadLine());

            if (num == 0)
                stack.Pop();
            else
                stack.Push(num);
        }

        foreach (var num in stack)
            result += num;

        sw.WriteLine(result);

        sw.Close();
    }
}