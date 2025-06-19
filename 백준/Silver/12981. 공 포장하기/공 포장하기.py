R, G, B = map(int, input().split())

min_value = min(R, G, B)

result = min_value

R -= min_value
G -= min_value
B -= min_value

R1, R = divmod(R, 3)
G1, G = divmod(G, 3)
B1, B = divmod(B, 3)

result += R1 + G1 + B1

if R == 2:
  result += 1
  R = 0
if G == 2:
  result += 1
  G = 0
if B == 2:
  result += 1
  B = 0
if R + G + B > 0:
  result += 1

print(result)