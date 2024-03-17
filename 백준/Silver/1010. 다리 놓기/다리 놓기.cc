#include<iostream>
int main()
{
	int count;
	long N, M;
	scanf("%d", &count);
	for (int i = 0; i < count; ++i)
	{
		long answer = 1;
		scanf("%ld %ld", &N, &M);
		for (int j = 0; j < N; ++j)
		{
			answer *= M-j;
			answer /= j + 1;
		}
		printf("%d\n", answer);
	}
}