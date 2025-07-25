using System.Text;

StringBuilder sb = new StringBuilder();
int N = int.Parse(Console.ReadLine());

List<int> mines = new List<int>();

for (int i = 0; i < N; i++)
    mines.Add(int.Parse(Console.ReadLine()));

for (int i = 0; i < N; i++)
{
    bool isLeftPeak = (i == 0) || mines[i] >= mines[i - 1];
    bool isRightPeak = (i == N - 1) || mines[i] >= mines[i + 1];

    if (isLeftPeak && isRightPeak)
        sb.AppendLine((i + 1).ToString());
}

Console.WriteLine(sb.ToString());