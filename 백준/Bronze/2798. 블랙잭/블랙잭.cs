using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]); // 카드의 개수
        int M = int.Parse(input[1]); // 합의 최댓값
        int[] cards = new int[N];

        string[] cardInput = Console.ReadLine().Split();
        for (int i = 0; i < N; i++)
        {
            cards[i] = int.Parse(cardInput[i]);
        }

        int maxSum = FindMaxSum(cards, N, M, 0, 0, 0);
        Console.WriteLine(maxSum);
    }

    static int FindMaxSum(int[] cards, int N, int M, int index, int selectedCards, int currentSum)
    {
        // 기저 사례: 3장을 모두 선택한 경우
        if (selectedCards == 3)
        {
            return currentSum;
        }

        // 기저 사례: 인덱스가 배열의 끝에 도달한 경우
        if (index >= N)
        {
            return 0;
        }

        // 현재 카드를 선택하는 경우
        int sum1 = 0;
        if (currentSum + cards[index] <= M)
        {
            sum1 = FindMaxSum(cards, N, M, index + 1, selectedCards + 1, currentSum + cards[index]);
        }

        // 현재 카드를 선택하지 않는 경우
        int sum2 = FindMaxSum(cards, N, M, index + 1, selectedCards, currentSum);

        // 두 경우 중에서 최대값을 반환
        return Math.Max(sum1, sum2);
    }
}