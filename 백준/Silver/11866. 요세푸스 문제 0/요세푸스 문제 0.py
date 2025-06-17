from collections import deque

N, K = map(int, input().split())
queue = deque(range(1, N + 1))
result = []

for _ in range(N):
  for i in range(K-1):
    queue.append(queue.popleft())
  result.append(str(queue.popleft()))

print("<"+", ".join(result)+">")