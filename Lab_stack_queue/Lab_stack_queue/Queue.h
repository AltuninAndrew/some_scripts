#pragma once
#include <list>
using namespace std;
template <typename TypeElements>
class Queue
{
public:
	~Queue();
	void Push(const TypeElements value);
	void Pop();
	void Show();
	TypeElements ReturnTopElement();
	
private:
	list<TypeElements> elements;
	int sizeQueue;
};

template<typename TypeElements>
inline Queue<TypeElements>::~Queue()
{
	elements.clear();
}

template<typename TypeElements>
inline void Queue<TypeElements>::Push(const TypeElements value)
{
	elements.push_back(value);
}

template<typename TypeElements>
inline void Queue<TypeElements>::Pop()
{
	elements.pop_front();
}

template<typename TypeElements>
inline void Queue<TypeElements>::Show()
{
	if (!elements.empty())
	{
		for (TypeElements element : elements)
		{
			cout << element << " ";
		}
		cout << "\n";
	}
	else
	{
		cout << "Queue is empty" << "\n";
	}
	
}

template<typename TypeElements>
inline TypeElements Queue<TypeElements>::ReturnTopElement()
{
	if (!elements.empty)
	{
		return elements.front();
	}
	else
	{
		cout << "\n" << "Queue is empty" << "\n";
		return NULL;
	}
	
}
