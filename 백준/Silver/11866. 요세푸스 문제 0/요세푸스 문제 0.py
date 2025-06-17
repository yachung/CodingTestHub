from collections import deque

N, K = map(int, input().split())
queue = deque(range(1, N + 1))
result = []

for _ in range(N):
  for i in range(K):
    value = queue.popleft()
    if i == K - 1:
      result.append(value)
    else:
      queue.append(value)
      
print("<",end="")
for i in range(N-1):
    print(result[i],end=", ")
print(result[N-1], end = "")
print(">",end="")