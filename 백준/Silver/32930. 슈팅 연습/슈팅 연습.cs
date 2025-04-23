using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int N = arr[0];
    int M = arr[1];
    int count = M;
    int score = 0;
    
    List<(int x, int y)> coords = new List<(int,int)>();
    
    for (int i = 0; i < N; ++i)
    {
        var parts = Console.ReadLine().Split();
        int x = int.Parse(parts[0]);
        int y = int.Parse(parts[1]);
        coords.Add((x, y));
    }
    
    Queue<(int x, int y)> newCoords = new Queue<(int, int)>();
    for (int i = 0; i < M; i++)
    {
        var parts = Console.ReadLine().Split();
        int x = int.Parse(parts[0]);
        int y = int.Parse(parts[1]);
        newCoords.Enqueue((x, y));
    }
    
    (int x, int y) pos = (0, 0);
    
    for(int i = 0; i < M; ++i)
    {
        int maxDistance = -1;
        int removeIdx = -1;
        
        for (int j = 0; j < coords.Count; ++j)
        {
            int dx = (coords[j].x - pos.x);
            int dy = (coords[j].y - pos.y);
            int distance = dx * dx + dy * dy;
            
            if (distance > maxDistance)
            {
                maxDistance = distance;
                removeIdx = j;
            }
        }
        
        score += maxDistance;
        pos = coords[removeIdx];
        coords.RemoveAt(removeIdx);
        coords.Add(newCoords.Dequeue());
    }
    
    Console.WriteLine(score);
  }
}