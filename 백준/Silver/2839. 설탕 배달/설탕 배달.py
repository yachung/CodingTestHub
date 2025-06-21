N = int(input())
result = -1

# 5kg 봉지를 최대한 사용하는 방식으로 시도
for five_kg in range(N // 5, -1, -1):
    remain = N - (five_kg * 5)
    if remain % 3 == 0:
        three_kg = remain // 3
        result = five_kg + three_kg
        break

print(result)