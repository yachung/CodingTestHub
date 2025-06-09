t = int(input())
for _ in range(t):
  n = int(input())
  xi = list(map(int, input().split()))
  min_value = min(xi);
  max_value = max(xi);
  mid = round(sum(xi) / n)
  print(((mid - min_value) + (max_value - mid)) * 2)