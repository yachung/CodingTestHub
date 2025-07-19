using System.Text;

int N = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
for (int i = 1; i <= N; ++i)
{
    for (int j = N; j >= 1; --j)
    {
        if (j > i)
            sb.Append(' ');
        else
            sb.Append('*');
    }
    sb.AppendLine();
}

Console.WriteLine(sb.ToString());