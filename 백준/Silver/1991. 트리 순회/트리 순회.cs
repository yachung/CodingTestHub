using System.Text;
using System.Xml.Linq;

public class Solution
{
    const char root = 'A';
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

        sb.AppendLine(Preorder(root));
        sb.AppendLine(Inorder(root));
        sb.AppendLine(Postorder(root));

        sw.WriteLine(sb.ToString());

        sw.Close();
        sr.Close();
    }

    public static string Preorder(char node) => node.Equals('.') ? "" : $"{node}{Preorder(graph[node][0])}{Preorder(graph[node][1])}";
    public static string Inorder(char node) => node.Equals('.') ? "" : $"{Inorder(graph[node][0])}{node}{Inorder(graph[node][1])}";
    public static string Postorder(char node) => node.Equals('.') ? "" : $"{Postorder(graph[node][0])}{Postorder(graph[node][1])}{node}";
}