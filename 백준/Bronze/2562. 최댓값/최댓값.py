max_value = 0
max_index = 0

for i in range(9):
  temp = int(input())
  if temp > max_value:
    max_value = temp
    max_index = i + 1
print(max_value)
print(max_index)