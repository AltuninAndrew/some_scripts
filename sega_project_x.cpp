#include <windows.h>
#include <iostream>
#include <stdio.h>
#include <math.h>
using namespace std;

double func(double x)
{
  return ((x*x*x*x)+pow(2.718,-x));
}
int main() 
{
  int i;
  double E=1;
  double a = 0, b = 1;
  double e;
  double x1 = a;
  double x2 = b;
  double f1,f2;
  double c = 0, delta;
  cout << "Enter accuracy: ";
  cin >> e;
  delta = 0.02;
	while (E>e)
	{
		
		E = (b-a)/2.0;
		cout << "# " << c++ << " ================================" << endl;
		cout << "E = " << E << endl;
		x1 = (a+b-e)/2.0;
		x2 = (a+b+e)/2.0;
		cout << "a = " << a << "     b = " << b << endl;
		cout << "x1 = " << x1 << "   x2 = " << x2 << endl;
		cout << "F(x1) = " << func(x1) << "   F(x2) = " << func(x2) << endl;
		cout << " ===================================" << endl << endl;
		if (func(x1) < func(x2)) b = x2;
		else a = x1;
}
	cout << "E = " << E << endl;
	cout << "x* = " << (a+b)/2.0 << "  F(x*) = " << func((a+b)/2.0) << endl;
  return 0;
}
