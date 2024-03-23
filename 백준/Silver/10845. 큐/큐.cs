using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int input = int.Parse(Console.ReadLine());

        string[] inputArr = new string[input];

        for (int i = 0; i < input; ++i)
            inputArr[i] = Console.ReadLine();

        Queue queue = new Queue(input);

        for (int i = 0; i < input; ++i)
        {
            string[] command = inputArr[i].Split();

            switch (command[0])
            {
                case "push":
                    int.TryParse(command[1], out int item);
                    queue.push(item);
                    break;
                case "pop":
                    sb.AppendLine(queue.pop().ToString());
                    break;
                case "size":
                    sb.AppendLine(queue.Size().ToString());
                    break;
                case "empty":
                    sb.AppendLine(queue.empty().ToString());
                    break;
                case "front":
                    sb.AppendLine(queue.Front().ToString());
                    break;
                case "back":
                    sb.AppendLine(queue.Back().ToString());
                    break;
            }
        }

        Console.WriteLine(sb);
    }

}

public class Queue
{
    private int[] items;
    private int capacity;
    private int front;
    private int back;
    private int size;

    public Queue(int capacity)
    {
        this.capacity = capacity;
        items = new int[capacity];
        front = 0;
        back = -1;
        size = 0;
    }

    public void push(int item)
    {
        items[++back] = item;
        size++;
    }

    public int pop()
    {
        if (IsEmpty())
            return -1;
        else
        {
            size--;
            return items[front++];
        }
    }

    public int empty()
    {
        if (IsEmpty())
            return 1;
        else
            return 0;
    }

    public int Front()
    {
        if (IsEmpty())
            return -1;
        else
            return items[front];
    }

    public int Back()
    {
        if (IsEmpty())
            return -1;
        else
            return items[back];
    }

    public int Size()
    {
        return size;
    }

    private bool IsEmpty()
    {
        if (size == 0)
            return true;
        else
            return false;
    }
}