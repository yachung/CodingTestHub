string[] input = Console.ReadLine().Trim().Split(" ");
int result = 0;
foreach (string s in input)
    if (!string.IsNullOrEmpty(s)) result++;
Console.WriteLine(result);