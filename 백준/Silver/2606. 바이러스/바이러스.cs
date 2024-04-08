using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int nCom = int.Parse(Console.ReadLine());
        int nPair = int.Parse(Console.ReadLine());

        Graph graph = new Graph(nCom);

        while (nPair-- > 0)
        {
            int[] pair = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            graph.AddEdge(pair[0], pair[1]);
        }

        graph.DFS(1);

        int virus = -1;
        foreach (var visit in graph.Visited())
        {
            if (visit)
                virus++;
        }

        Console.WriteLine(virus);
    }
}

class Graph
{
    private StringBuilder dfsSB = new StringBuilder();
    private StringBuilder bfsSB = new StringBuilder();
    
    private List<int>[] adjacencyList;
    private bool[] visited;

    private int vertex;

    public Graph(int vertex)
    {
        this.vertex = vertex;

        adjacencyList = new List<int>[vertex + 1];
        visited = new bool[vertex + 1];

        for (int i = 0; i < vertex + 1; i++)
            adjacencyList[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adjacencyList[v].Add(w);
        adjacencyList[w].Add(v);
    }

    public bool[] Visited()
    {
        return visited;
    }

    public void Sort()
    {
        foreach (var list in adjacencyList)
        {
           list.Sort();
        }
    }

    public void DFS(int vertex)
    {
        dfsSB.Append($"{vertex} ");
        visited[vertex] = true;

        foreach (var node in adjacencyList[vertex])
        {
            if (!visited[node])
                DFS(node);
        }
    }

    public void BFS(int vertex)
    {
        Queue<int> queue = new Queue<int>();

        visited[vertex] = true;
        queue.Enqueue(vertex);
        bfsSB.Append($"{vertex} ");

        while (queue.Count != 0)
        {
            vertex = queue.Dequeue();

            foreach (int node in adjacencyList[vertex])
            {
                if (!visited[node])
                {
                    visited[node] = true;
                    queue.Enqueue(node);
                    bfsSB.Append($"{node} ");
                }
            }
        }
    }

    public void VisitedReset()
    {
        visited = new bool[vertex + 1];
    }

    public void Output()
    {
        Console.WriteLine(dfsSB);
        Console.WriteLine(bfsSB);
    }
}