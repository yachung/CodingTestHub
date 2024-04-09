using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 오, 아, 왼, 위
        (int, int)[] directions = { (1, 0), (0, 1), (-1, 0), (0, -1) };
        bool[,] visited;

        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int N = input[0];
        int M = input[1];
        int dist = 0;

        int[,] maps = new int[N, M];
        visited = new bool[N,M];

        for (int i = 0; i < N; ++i)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < M; ++j)
            {
                maps[i, j] = row[j] - '0';
            }
        }

        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        queue.Enqueue((0, 0, 1));
        visited[0, 0] = true;

        while (queue.Count != 0)
        {
            (int, int, int) current = queue.Dequeue();

            if (current.Item1 == N - 1 && current.Item2 == M - 1)
            {
                dist = current.Item3;
                break;
            }

            foreach (var dir in directions)
            {
                int nX = current.Item1 + dir.Item1;
                int nY = current.Item2 + dir.Item2;

                if (nX < 0 || nX >= N || nY < 0 || nY >= M || maps[nX,nY] == 0 || visited[nX, nY])
                    continue;

                queue.Enqueue((nX, nY, current.Item3 + 1));
                visited[nX, nY] = true;
            }
        }

        Console.WriteLine(dist);
    }
}