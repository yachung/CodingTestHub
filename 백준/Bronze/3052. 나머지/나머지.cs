HashSet<int> set = new HashSet<int>();
for (int i = 0; i < 10; i++)
{
    int input = int.Parse(Console.ReadLine());
    input %= 42;
    set.Add(input);
}
Console.WriteLine(set.Count);