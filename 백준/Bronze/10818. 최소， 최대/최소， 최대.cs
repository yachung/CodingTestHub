int N = int.Parse(Console.ReadLine());
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int min = 1000000, max = -1000000;
foreach (var item in inputs)
{
    if (min > item) min = item;
    if (max < item) max = item;
}
Console.WriteLine($"{min} {max}");