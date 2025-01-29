#include <iostream>
#include <string>
using namespace std;

int main()
{
	int T;
	cin >> T;

	int gan[6] = { 1, 2, 3, 3, 4, 10};
	int sau[7] = { 1, 2, 2, 2, 3, 5, 10};

	for (int i = 1; i <= T; ++i)
	{
		int sum1 = 0, sum2 = 0;

		for (int j = 0; j < 6; ++j)
		{
			int var;
			cin >> var;
			sum1 += var * gan[j];
		}
		for (int k = 0; k < 7; ++k)
		{
			int var;
			cin >> var;
			sum2 += var * sau[k];
		}

		cout << "Battle " << i << ": ";

		if (sum1 > sum2)
			cout << "Good triumphs over Evil"<< "\n";
		else if (sum1 < sum2)
			cout << "Evil eradicates all trace of Good" << "\n";
		else if (sum1 == sum2)
			cout << "No victor on this battle field" << "\n";
	}
}