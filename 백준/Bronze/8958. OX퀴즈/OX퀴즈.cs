using System.Text;

int N = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
for (int i = 0; i < N; i++)
{
    string input = Console.ReadLine();
    int sum = 0, score = 0;
    foreach (var item in input)
    {
        if (item.Equals('O'))
            score++;
        else
            score = 0;
        sum += score;
    }
    sb.AppendLine(sum.ToString());
}
Console.WriteLine(sb.ToString());