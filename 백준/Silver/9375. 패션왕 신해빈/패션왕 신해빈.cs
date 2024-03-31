using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int inputTC = int.Parse(Console.ReadLine());

        Dictionary<string, int> dicClothes = new Dictionary<string, int>();

        while (inputTC-- > 0)
        {
            dicClothes.Clear();

            int cNum = int.Parse(Console.ReadLine());

            while (cNum-- > 0)
            {
                string[] strClothes = Console.ReadLine().Split();

                if (dicClothes.ContainsKey(strClothes[1]))
                    dicClothes[strClothes[1]]++;
                else
                    dicClothes.Add(strClothes[1], 1);
            }

            int cases = 0;

            foreach (var item in dicClothes.Values)
                cases = item + item * cases + cases;

            sb.Append($"{cases}\n");
        }

        Console.WriteLine(sb);
    }
}