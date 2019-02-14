#include "stdafx.h"
#include <iostream>
#include "Stack.h"
#include "Queue.h"
using namespace std;


int _tmain(int argc, _TCHAR* argv[])
{
	//stack
	cout<<"Enter size stack"<<"\n";
	int size= 0;
	cin>>size;
	Stack<int> stack(size);
	cout << "Enter numbers"<<"\n";
	int value = 0;
	for (int i = 0; i < size; i++)
	{
		cin >> value;
		stack.Push(value);
	}
	cout << "Your stack: " << "\n";
	stack.Show();
	cout << "For example, two items are removed"<<"\n";
	stack.Pop();
	stack.Pop();
	cout << "Your stack: "<<"\n";
	stack.Show();

	//queue
	cout << "Enter size queue" << "\n";
	cin >> size;
	Queue<int> queue;
	cout << "Enter numbers" << "\n";
	for (int i = 0; i < size; i++)
	{
		cin >> value;
		queue.Push(value);
	}
	cout << "Your queue: " << "\n";
	queue.Show();
	cout << "For example, two items are removed" << "\n";
	queue.Pop();	
	queue.Pop();
	cout << "Your queue: " << "\n";
	queue.Show();

	system("pause");
	return 0;
}

