using System;
using System.Collections.Generic;

class Program
{
    static int N, M;
    static char[,] maps;
    static bool[,] visited;
    static (int x, int y)[] directions = { (1, 0), (0, 1), (-1, 0), (0, -1) };

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);

        maps = new char[N, M];
        visited = new bool[N, M];
        (int, int) start = default;

        for (int i = 0; i < N; i++)
        {
            string data = Console.ReadLine();
            for (int j = 0; j < M; j++)
            {
                maps[i, j] = data[j];
                if (maps[i, j] == 'I')
                {
                    start = (i, j);
                }
            }
        }

        int result = BFS(start);
        Console.WriteLine(result == 0 ? "TT" : result);
    }

    static int BFS((int, int) start)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue(start);
        visited[start.Item1, start.Item2] = true;
        int count = 0;

        while (queue.Count > 0)
        {
            var (currentX, currentY) = queue.Dequeue();
            if (maps[currentX, currentY] == 'P') 
                count++;

            foreach (var dir in directions)
            {
                int dx = currentX + dir.x;
                int dy = currentY + dir.y;

                if (dx >= 0 && dx < N && dy >= 0 && dy < M)
                {
                    if (!visited[dx, dy] && maps[dx, dy] != 'X')
                    {
                        visited[dx, dy] = true;
                        queue.Enqueue((dx, dy));
                    }
                }
            }
        }

        return count;
    }
}