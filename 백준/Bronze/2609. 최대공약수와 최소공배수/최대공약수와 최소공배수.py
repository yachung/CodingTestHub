input_value = list(map(int, input().split()))
a = input_value[0]
b = input_value[1];

count = 1;
divisor = 1

while(True) :
  if a % count == 0 and b % count == 0 :
    a /= count
    b /= count
    divisor *= count
    count = 2
  elif count > a or count > b :
    print(divisor)
    break
  else:
    count += 1

a = input_value[0]
b = input_value[1]

multiple = a / divisor * b / divisor * divisor
print(int(multiple))