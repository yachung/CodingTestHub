using System.Text;
using System.Xml.Linq;

public class Solution
{
    static List<char> visited = new List<char>();
    static Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>();

    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int N = int.Parse(sr.ReadLine());
        

        for (int i = 0; i < N; i++)
        {
            char[] input = Array.ConvertAll(sr.ReadLine().Split(), char.Parse);
            
            graph.Add(input[0], new List<char> { input[1], input[2] });
        }

        Preorder('A');
        foreach (var item in visited)
            sb.Append(item);
        sb.AppendLine();
        visited = new List<char>();
        Inorder('A');
        foreach (var item in visited)
            sb.Append(item);
        sb.AppendLine();
        visited = new List<char>();
        Postorder('A');
        foreach (var item in visited)
            sb.Append(item);

        sw.WriteLine(sb.ToString());

        sw.Close();
    }

    public static void Preorder(char node)
    {
        if (!graph.ContainsKey(node))
            return;

        visited.Add(node);
        Preorder(graph[node][0]);
        Preorder(graph[node][1]);
    }

    public static void Inorder(char node)
    {
        if (!graph.ContainsKey(node))
            return;

        Inorder(graph[node][0]);
        visited.Add(node);
        Inorder(graph[node][1]);
    }

    public static void Postorder(char node)
    {
        if (!graph.ContainsKey(node))
            return;

        Postorder(graph[node][0]);
        Postorder(graph[node][1]);
        visited.Add(node);
    }
}