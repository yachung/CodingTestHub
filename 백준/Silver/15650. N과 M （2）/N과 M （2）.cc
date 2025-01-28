#include <iostream>
using namespace std;

int N, M;
int arr[9];
int visited[9];

void Recursive(int cnt, int num)
{
	if (cnt == M)
	{
		for (int i = 0; i < M; ++i)
		{
			cout << arr[i] << " ";
		}
		cout << "\n";
	}
	for (int i = num; i <= N; ++i)
	{
		if (!visited[i])
		{
			visited[i] = true;
			arr[cnt] = i;
			Recursive(cnt + 1, i + 1);
			visited[i] = false;
		}
	}
}

int main()
{
	cin >> N >> M;

	Recursive(0, 1);
}