class Program
{
    static int whiteCount = 0;
    static int blueCount = 0;

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[,] paperArray = new int[N, N];

        for (int i = 0; i < N; ++i)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < N; ++j)
            {
                paperArray[i, j] = int.Parse(row[j]);
            }
        }

        CheckFunction(paperArray, 0, 0, N);

        Console.WriteLine($"{whiteCount}\n{blueCount}");
    }

    static void CheckFunction(int[,] array, int x, int y, int size)
    {
        int selectColor = array[x, y];

        for (int i = x; i < x + size; ++i)
        {
            for (int j = y; j < y + size; ++j)
            {
                if (selectColor != array[i, j])
                {
                    CheckFunction(array, x, y, size / 2);
                    CheckFunction(array, x + size / 2, y, size / 2);
                    CheckFunction(array, x, y + size / 2, size / 2);
                    CheckFunction(array, x + size / 2, y + size / 2, size / 2);

                    return;
                }
            }
        }

        if (selectColor == 0)
            whiteCount++;
        else if (selectColor == 1)
            blueCount++;
    }
}