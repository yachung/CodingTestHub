class Program
{
    static void Main(string[] args)
    {
        int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int N = inputArray[0];
        int K = inputArray[1];

        Console.WriteLine(BFS(N, K));
    }

    static int BFS(int N, int K)
    {
        int count = 0;

        Queue<(int position, int time)> queue = new Queue<(int, int)>();
        bool[] visited = new bool[100001];

        queue.Enqueue((N, 0));
        visited[N] = true;

        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            int X = item.position;
            int time = item.time;

            if (X == K)
            {
                count = time;
                break;
            }

            if (2 * X <= 100000 && !visited[2 * X])
            {
                queue.Enqueue((2 * X, time + 1));
                visited[2 * X] = true;
            }

            if (X + 1 <= 100000 && !visited[X + 1])
            {
                queue.Enqueue((X + 1, time + 1));
                visited[X + 1] = true;
            }

            if (X - 1 >= 0 && !visited[X - 1])
            {
                queue.Enqueue((X - 1, time + 1));
                visited[X - 1] = true;
            }
        }

        return count;
    }
}
