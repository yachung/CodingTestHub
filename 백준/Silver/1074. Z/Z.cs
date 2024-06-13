class Program
{
    static int count = -1;
    static (int x, int y)[] sequenceList = 
        {(0, 0), (1, 0), (-1, 1), (1, 0) };
    static void Main(string[] args)
    {
         int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int N = inputArray[0];
        int r = inputArray[1];
        int c = inputArray[2];

        int width = (int)Math.Pow(2, N);
        int height = width;

        Function(N, c, r, 0, 0);

        Console.WriteLine(count);
    }

    static void Function (int N, int col, int row, int curX, int curY)
    {
        if (N <= 1)
        {
            foreach (var sequence in sequenceList)
            {
                curX += sequence.x;
                curY += sequence.y;

                count++;

                if (curX == col && curY == row)
                {
                    return;
                }
            }
        }

        int height = (int)Math.Pow(2, N);
        int width = height;


        int addCount = height * width / 4;

        // 1사분면
        if (col < curX + height / 2 && row < curY + width / 2)
        {
        }
        // 2사분면
        else if (col >= curX + height / 2 && row < curY + width / 2)
        {
            count += addCount;
            curX += width / 2;
        }
        // 3사분면
        else if (col < curX + height / 2 && row >= curY + width / 2)
        {
            count += addCount * 2;
            curY += height / 2;
        }
        // 4사분면
        else
        {
            count += addCount * 3;
            curX += width / 2;
            curY += height / 2;
        }

        Function(N - 1, col, row, curX, curY);
    }
}