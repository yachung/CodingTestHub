using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int n = int.Parse(Console.ReadLine());

        // 우선순위 큐를 사용하여 최소 힙 구현
        PriorityQueue<int> minHeap = new PriorityQueue<int>();

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                if (minHeap.Count == 0)
                {
                    sb.AppendLine("0");
                }
                else
                {
                    sb.Append($"{minHeap.Dequeue()}\n");
                }
            }
            else
            {
                minHeap.Enqueue(x);
            }
        }

        Console.WriteLine(sb);
    }
}

// 우선순위 큐 클래스 구현
class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> heap = new List<T>();

    public int Count { get { return heap.Count; } }

    public void Enqueue(T item)
    {
        heap.Add(item);
        int i = Count - 1;
        while (i > 0)
        {
            int parent = (i - 1) / 2;
            if (heap[parent].CompareTo(heap[i]) <= 0)
                break;
            Swap(parent, i);
            i = parent;
        }
    }

    public T Dequeue()
    {
        T result = heap[0];
        heap[0] = heap[Count - 1];
        heap.RemoveAt(Count - 1);

        int i = 0;
        while (true)
        {
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            int smallest = i;

            if (leftChild < Count && heap[leftChild].CompareTo(heap[smallest]) < 0)
                smallest = leftChild;
            if (rightChild < Count && heap[rightChild].CompareTo(heap[smallest]) < 0)
                smallest = rightChild;

            if (smallest == i)
                break;

            Swap(i, smallest);
            i = smallest;
        }

        return result;
    }

    private void Swap(int i, int j)
    {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}