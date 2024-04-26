using System;

class Program
{
    static void Main(string[] args)
    {
        var sizes = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int M = sizes[0];
        int N = sizes[1];
        int minValue = int.MaxValue;

        string[] board = new string[M];

        for (int i = 0; i < M; i++) 
            board[i] = Console.ReadLine();

        int count = 0;
        char check = board[0][0];

        for (int i = 0; i < M - 7; i++)
        {
            for (int j = 0; j < N - 7; j++) 
            {
                count = 0;

                check = 'B';

                for (int k = i; k < i + 8; k++)
                {
                    for (int l = j; l < j + 8; l++)
                    {
                        if ((k + l) % 2 == 0)
                        {
                            if (board[k][l] != check)
                            {
                                count++;
                            }
                        }
                        else
                        {
                            if (board[k][l] == check)
                            {
                                count++;
                            }
                        }
                    }
                }

                minValue = Math.Min(minValue, count);

                count = 0;

                check = 'W';

                for (int k = i; k < i + 8; k++)
                {
                    for (int l = j; l < j + 8; l++)
                    {
                        if ((k + l) % 2 == 0)
                        {
                            if (board[k][l] != check)
                            {
                                count++;
                            }
                        }
                        else
                        {
                            if (board[k][l] == check)
                            {
                                count++;
                            }
                        }
                    }
                }

                minValue = Math.Min(minValue, count);
            }
        }

        Console.WriteLine(minValue);
    }
}