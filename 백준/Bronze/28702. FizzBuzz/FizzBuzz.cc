#include<iostream>
#include <string>
using namespace std;

int main()
{
	int result = 0;
	string inputs[3];

	cin >> inputs[0];
	cin >> inputs[1];
	cin >> inputs[2];

	for (int i = 0; i < sizeof(inputs); ++i)
	{
		if (inputs[i].compare("FizzBuzz") == 0)
			continue;
		if (inputs[i].compare("Fizz") == 0)
			continue;
		if (inputs[i].compare("Buzz") == 0)
			continue;

		int value = stoi(inputs[i]);
		result = value + 3 - i;

		break;
	}

	if (result % 3 == 0)
		if (result % 5 == 0)
			cout << "FizzBuzz";
		else
			cout << "Fizz";
	else if (result % 5 == 0)
		cout << "Buzz";
	else
		cout << result;
}