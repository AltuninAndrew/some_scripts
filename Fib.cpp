#include <iostream>
using namespace std;

int fib(unsigned int n)
{
    	if (n < 2) return n;
    	return fib(n - 1) + fib(n - 2);
}

int fib_n(int n)
{
	int x = 1;
	int y = 0;
	for (int i = 1; i < n; i++)
	{
		x += y;
		y = x - y;
	}
	return y;
}

int main()
{
	int num = fib(4);
	cout<<num;
	return 0;
}
