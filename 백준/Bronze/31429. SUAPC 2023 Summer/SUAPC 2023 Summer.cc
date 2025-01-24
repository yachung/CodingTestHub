#include <iostream>
using namespace std;

int main()
{
	int input;
	cin >> input;

	int score[] = {1600, 894, 1327, 1311, 1004, 1178, 1357, 837, 1055, 556, 773};
	int problem[] = { 12, 11, 11, 10, 9, 9, 9, 8, 7, 6, 6 };

	cout << problem[input - 1]<< " " << score[input - 1];

	return 0;
}