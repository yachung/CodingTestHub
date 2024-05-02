using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int TC = int.Parse(Console.ReadLine());
        
        while (TC-- > 0)
        {
            var input = Console.ReadLine().Split();
            
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int[] docs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Node[] nodeArr = new Node[1000];
            int cnt = 0;

            for (int i = 0; i < docs.Length; i++)
                nodeArr[i] = new Node(i, docs[i]);

            Array.Sort(docs, (a, b) => 
            {
                return b.CompareTo(a);
            });

            int priorityIdx = 0;
            int end = docs.Length - 1;
            int size = docs.Length;
            int idx = 0;

            while (size > 0)
            {
                if (nodeArr[idx].priority == docs[priorityIdx])
                {
                    cnt++;

                    if (nodeArr[idx].originIdx == M)
                        break;

                    priorityIdx++;
                    idx++;
                    size--;
                }
                else
                {
                    nodeArr[++end] = nodeArr[idx++];
                }
            }

            sb.AppendLine(cnt.ToString());
        }

        Console.WriteLine(sb.ToString());
    }
}

struct Node : IComparable<Node>
{
    public int originIdx;
    public int priority;

    public Node(int originIdx, int priority)
    {
        this.originIdx = originIdx;
        this.priority = priority;
    }

    public int CompareTo(Node node) => priority.CompareTo(node.priority);
}