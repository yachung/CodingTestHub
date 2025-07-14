int N = int.Parse(Console.ReadLine());
int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Console.WriteLine($"{B.Sum()} {A.Sum()}");