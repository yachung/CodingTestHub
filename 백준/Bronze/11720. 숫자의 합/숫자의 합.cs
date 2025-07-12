int N = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
int sum = 0;
foreach (var item in input)
    sum += (int)item-'0';
Console.WriteLine(sum);
