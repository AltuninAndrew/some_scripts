#pragma once

template<typename TypeElements>
class Stack
{
public:
	Stack(int sizeStack);
	~Stack();
	void Push(const TypeElements value);
	void Pop();
	void Show();
	int pointTopElement;
	TypeElements ReturnFirstElement();
private:
	TypeElements *element;
	int sizeSteck;


};

template<typename TypeElements>
Stack<TypeElements>::Stack(int sizeStack)
{
	this->sizeSteck = sizeStack;
	element = new TypeElements[sizeStack];
	pointTopElement = -1;
}


template<typename TypeElements>
Stack<TypeElements>::~Stack()
{
	delete [] element;

}

template<typename TypeElements>
void Stack<TypeElements>::Push(const TypeElements value)
{
	if (pointTopElement == sizeSteck-1)
	{
		cout<<"Stack overflow";
	}
	else
	{ 
		pointTopElement++;
		element[pointTopElement] = value;
	}
}


template<typename TypeElements>
void Stack<TypeElements>::Pop()
{
	if (pointTopElement==-1)
	{
		cout<<"stack is empty";
	}
	else
	{
		element[pointTopElement]=0;
		pointTopElement--;	
	}
	
}

template<typename TypeElements>
void Stack<TypeElements>::Show()
{
	if (pointTopElement != -1)
	{
		for (int i = pointTopElement; i >= 0; i--)
		{
			cout << element[i] << " ";
		}
		cout << "\n";
	}
	else
	{
		cout << "Stack is empty"<<"\n";
	}
	

	
}

template<typename TypeElements>
TypeElements Stack<TypeElements>::ReturnFirstElement()
{
	if (pointTopElement==-1)
	{
		cout<<"NULL";
	}
		
	else
	{
		return element[pointTopElement];
	}
	
}

