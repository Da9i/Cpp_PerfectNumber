#include<iostream>
using namespace std;
bool perfectNumber(int n)
{
	int i = 1, sum = 0;
	while (i < n)
	{
		if (n%i == 0)
			sum += i;
		i++;
	}
	if (sum == n)
		return true;
	else
		return false;
}
void perfectNumberTill1000(int num = 1000)
{
	bool check;
	for (int i = 1; i <= num; i++)
	{
		check = perfectNumber(i);
		if (check == false)
			cout << i << " IS NOT A PERFECT NUMBER!!!\n";
		else
			cout << i << " IS A PERFECT NUMBER!!!\n";
	}
}
int main()
{
	cout << "ENTER RANGE TO CHECK THE PERFECT NUMBER BETWEEN THAT RANGE:";
	int a;
	cin >> a;
	perfectNumberTill1000(a);
	system("pause>0");
}
