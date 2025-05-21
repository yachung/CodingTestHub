using System;
using System.Text;

public class Solution
{
    static HashSet<int>[] graph;
    static void Main(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int N = input[0];
        int M = input[1];

        int minValue = int.MaxValue;
        int minIdx = -1;

        graph = new HashSet<int>[N + 1];

        for (int i = 0; i <= N; i++)
        {
            graph[i] = new HashSet<int>();
        }

        for (int i = 1; i <= M; ++i)
        {
            int[] line = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int A = line[0];
            int B = line[1];
            graph[A].Add(B);
            graph[B].Add(A);
        }

        for (int i = 1; i <= N; ++i)
        {
            if (minValue > BFS(i))
            {
                minValue = BFS(i);
                minIdx = i;
            }
        }

        sw.WriteLine(minIdx);

        sr.Close();
        sw.Close();
    }

    static int BFS(int i)
    {
        int result = 0;

        Queue<(int, int)> q = new Queue<(int, int)>();
        HashSet<int> visited = new HashSet<int>();

        q.Enqueue((i, 0));

        while (q.Count > 0)
        {
            (int value, int depth) = q.Dequeue();

            if (visited.Contains(value))
                continue;

            visited.Add(value);

            result += depth;

            foreach (var item in graph[value])
            {
                q.Enqueue((item, depth + 1));
            }
        }

        return result;
    }
}