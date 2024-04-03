using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int vertex = inputArr[0];
        int edges = inputArr[1];
        int start = inputArr[2];

        Graph graph = new Graph(vertex);

        while (edges-- > 0)
        {
            int[] edge = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            graph.AddEdge(edge[0], edge[1]);
        }

        graph.Sort();

        graph.DFS(start);

        graph.VisitedReset();

        graph.BFS(start);

        graph.Output();
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

    public void Sort()
    {
        foreach (var list in adjacencyList)
        {
           list.Sort();
        }
    }

    public void DFS(int vertex)
    {
        if (!visited[vertex])
        {
            dfsSB.Append($"{vertex} ");
            visited[vertex] = true;
        }

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