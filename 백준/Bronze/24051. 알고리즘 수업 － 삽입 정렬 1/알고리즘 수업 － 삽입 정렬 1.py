N, K = map(int, input().split())
A = list(map(int, input().split()))
cnt = 0;

for i in range(1, N) :
  loc = i - 1;
  newItem = A[i];
  while (0 <= loc and newItem < A[loc]):
    A[loc + 1] = A[loc];
    loc -= 1
    cnt += 1
    if cnt == K:
      print(A[loc + 1])
      exit()

  if loc + 1 != i:
    A[loc + 1] = newItem
    cnt+=1
    if cnt == K:
      print(A[loc + 1])
      exit()
      
if (cnt < K):
  print(-1);