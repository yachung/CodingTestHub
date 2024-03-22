#include<stdio.h>
#include<iostream>
#include<queue>
#include<cmath>
#pragma warning(disable:4996)
using namespace std;

int input();
int calc(int x1, int y1, int r1, int x2, int y2, int r2);
queue<int> output;

int main() {

	int t;
	scanf("%d", &t);
	int temp = t;
	while (0 < temp) {
		input();
		temp--;
	}
	return 0;
}
int input() {
	int x1, y1, r1, x2, y2, r2;
	scanf("%d %d %d %d %d %d", &x1, &y1, &r1, &x2, &y2, &r2);
	if (x1>= -10000 && x1<= 10000 && y1 >= -10000 && y1 <= 10000 && x2 >= -10000 && x2 <= 10000 && y2 >= -10000 && y2 <= 10000 && r1>= 0 && r1<= 10000 && r2 >= 0 && r2 <= 10000) {
		return calc(x1, y1, r1, x2, y2, r2);
	}
	else
		return -1;
	
}
int calc(int x1, int y1, int r1, int x2, int y2, int r2) {
	int a = x1 - x2;
	int b = y1 - y2;
	double c = (pow(x1, 2) + pow(y1, 2) - pow(r1, 2) - pow(x2, 2) - pow(y2, 2) + pow(r2, 2)) / 2;

	if (a==0 && b==0 && r1==r2) {
		printf("-1\n");
	}
	else if (pow(x1 - x2, 2) + pow(y1 - y2, 2) == pow(r1 + r2, 2)) {
		printf("1\n");
	}
	else if (pow(x1 - x2, 2) + pow(y1 - y2, 2) < pow(r1 + r2, 2)) {
		if (sqrt(pow(x1 - x2, 2) + pow(y1 - y2, 2)) + r1 == r2 || sqrt(pow(x1 - x2, 2) + pow(y1 - y2, 2)) + r2 == r1) {
			printf("1\n");
			return 0;
		}
		if (sqrt(pow(x1 - x2, 2) + pow(y1 - y2, 2)) + r1 < r2 || sqrt(pow(x1 - x2, 2) + pow(y1 - y2, 2)) + r2 < r1) {
			printf("0\n");
			return 0;
		}
		printf("2\n");
	}
	else
		printf("0\n");

	return 0;
}
