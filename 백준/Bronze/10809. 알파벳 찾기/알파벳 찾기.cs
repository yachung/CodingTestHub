using System.Text;

string S = Console.ReadLine();
const string alphabet = "abcdefghijklmnopqrstuvwxyz";

StringBuilder sb = new StringBuilder();
Dictionary<char, int> map = new Dictionary<char, int>();
for (int i = 0; i < S.Length; i++)
    map.TryAdd(S[i], i);

foreach (var item in alphabet)
{
    if (map.ContainsKey(item))
        sb.Append($"{map[item]} ");
    else
        sb.Append($"-1 ");
}

Console.WriteLine( sb.ToString() );