using System;
using System.Collections.Generic;

class Program
{
    static bool[] visited;
    static List<int>[] adjacencyList;

    static void Main(string[] args)
    {
        int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int N = inputArray[0];
        int M = inputArray[1];
        int count = 0;

        visited = new bool[N + 1];
        adjacencyList = new List<int>[N + 1];

        for (int i = 1; i < N + 1; ++i)
        {
            adjacencyList[i] = new List<int>();
        }

        for (int i = 0; i < M; ++i)
        {
            inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int from = inputArray[0];
            int to = inputArray[1];

            adjacencyList[from].Add(to);
            adjacencyList[to].Add(from);
        }

        for (int i = 1; i < N + 1; ++i)
        {
            if (!visited[i])
            {
                count++;
                dfs(i);
            }
        }

        Console.WriteLine(count);
    }

    public static void dfs(int index)
    {
        visited[index] = true;

        foreach (var next in adjacencyList[index])
        {
            if (visited[next])
                continue;

            dfs(next);
        }
    }
}
