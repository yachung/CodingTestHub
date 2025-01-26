#include <iostream>
using namespace std;

int main()
{
	int N;
	cin >> N;

	int odd = 0;
	int even = 0;

	for (int i = 0; i < N; ++i)
	{
		int var;
		cin >> var;
		if (var % 2 == 0)
			even++;
		else
			odd++;
	}

	if (odd == even)
	{
		cout << odd + even;
	}
	else if (odd > even)
	{
		int var = odd - even;

		if (var % 3 == 0)
		{
			cout << even * 2 + (var / 3) * 2;
		}
		else if (var % 3 == 1)
		{
			cout << even * 2 + (var / 3) * 2 - 1;
		}
		else if (var % 3 == 2)
		{
			cout << even * 2 + (var / 3) * 2 + 1;
		}
	}
	else if (even > odd)
	{
		cout << odd * 2 + 1;
	}
}