using System;
using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());

            PriorityQueue priorityQueue = new PriorityQueue();

            while (N-- > 0)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == 0) sb.AppendLine(priorityQueue.Dequeue().ToString());
                else priorityQueue.Enqueue(input);
            }

            Console.WriteLine(sb);
        }
    }

    class PriorityQueue : IComparer<int>
    {
        private List<int> heap = new List<int>();
        private void Swap(int i, int j) => (heap[i], heap[j]) = (heap[j], heap[i]);

        public bool IsEmpty => heap.Count == 0;

        public void Enqueue(int n)
        {
            heap.Add(n);

            int index = heap.Count - 1;

            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (Compare(parent, index) <= 0)
                    break;

                Swap(parent, index);
                index = parent;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty) return 0;

            int result = heap[0];
            
            Swap(0, heap.Count - 1);
            heap.RemoveAt(heap.Count - 1);

            int index = 0;
            while (true)
            {
                int minimum = index;

                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                if (leftChild < heap.Count && Compare(leftChild, minimum) <= 0)
                    minimum = leftChild;

                if (rightChild < heap.Count && Compare(rightChild, minimum) <= 0)
                    minimum = rightChild;

                if (minimum == index) break;

                Swap(index, minimum);
                index = minimum;
            }

            return result;
        }

        public int Compare(int x, int y)
        {
            if (IsEmpty || x < 0 || y < 0) return -1;

            if (Math.Abs(heap[x]) > Math.Abs(heap[y])) return 1;
            else if (Math.Abs(heap[x]) == Math.Abs(heap[y]))
            {
                if (heap[x] > heap[y]) return 1;
                else if (heap[x] == heap[y]) return 0;
                else return -1;
            }
            else return -1;
        }
    }
}