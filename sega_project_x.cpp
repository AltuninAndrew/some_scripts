#include <windows.h>
#include <iostream>
#include <stdio.h>
#include <math.h>
using namespace std;

double func(double x)
{
  return ((x*x*x*x)+8*x*x*x-6*x*x-72*x);
}
double lg (double x, double y)
{
	return (log(y)/log(x));
}
int main() 
{
  int i;
  double E=1;
  double a = 1.5, b = 2.0;
  double e = 0.05;
  double x1 = a;
  double x2 = b;
  double f1,f2;
  double v,c = 0, delta;
  cout << "Enter accuracy: ";
  cin >> e;
  delta = e;
 	 /*
  v = lg(2, (b-a -e)/(2*e - delta));
	cout << (int)v+2;
	*/
//	for (int i = 0; i<v;i++)
	while (E>e)
	{
		
		E = (b-a)/2.0;
		cout << "# " << c++ << "===============" << endl;
		cout << "E = " << E << endl;
		x1 = (a+b-e)/2.0;
		x2 = (a+b+e)/2.0;
		cout << "a = " << a << "   b = " << b << endl;
		cout << "x1 = " << x1 << "   x2 = " << x2 << endl;
		cout << "F(x1) = " << func(x1) << "   F(x2) = " << func(x2) << endl;
		cout << "==================" << endl << endl;
		if (func(x1) < func(x2)) b = x2;
		else a = x1;
}

  return 0;
}
