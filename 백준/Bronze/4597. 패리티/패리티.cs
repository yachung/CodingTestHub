using System.Text;

StringBuilder sb = new StringBuilder();
while (true)
{
    string input = Console.ReadLine();
    if (input.Equals("#")) break;

    string partial = input.Substring(0, input.Length - 1);
    int count = input.Count(a => a == '1');
    char finalBit;

    if (input.EndsWith('e'))
        finalBit = count % 2 == 0 ? '0' : '1';
    else
        finalBit = count % 2 == 0 ? '1' : '0';

    sb.AppendLine(partial + finalBit);
}
Console.WriteLine(sb);