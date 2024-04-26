using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var N = int.Parse(Console.ReadLine());
        var seq = new int[N];

        for (int i = 0; i < N; i++) 
            seq[i] = int.Parse(Console.ReadLine());
        
        Console.WriteLine(Function(seq));
    }

    static string Function(int[] seq)
    {
        StringBuilder sb = new StringBuilder();
        Stack<int> stack = new Stack<int>();
        var idx = 1;

        foreach (var item in seq)
        {
            if (stack.TryPeek(out int n))
            {
                if (n == item)
                {
                    stack.Pop();
                    sb.AppendLine("-");
                }
                else if (n > item)
                {
                    return "NO";
                }
                else if (n < item)
                {
                    for (int i = idx; i <= item; ++i)
                    {
                        stack.Push(i);
                        sb.AppendLine("+");
                    }

                    stack.Pop();
                    sb.AppendLine("-");

                    idx = item + 1;
                }
            }
            else
            {
                for (int i = idx; i <= item; ++i)
                {
                    stack.Push(i);
                    sb.AppendLine("+");
                }

                stack.Pop();
                sb.AppendLine("-");

                idx = item + 1;
            }
        }

        return sb.ToString();
    }
}