#include "stdafx.h"
#include "Stack.h"
#include <iostream>
using namespace std;


//
////template<typename TypeElements>
////Stack<TypeElements>::Stack(int sizeStack)
////{
////	this->sizeSteck = sizeStack;
////	element = new TypeElements[sizeStack];
////	topElement = -1;
////}
////
////
////template<typename TypeElements>
////Stack<TypeElements>::~Stack()
////{
////	delete [] element;
////
////}
////
////template<typename TypeElements>
////void Stack<TypeElements>::Push(const TypeElements value)
////{
////	if (topElement == sizeSteck-1)
////	{
////		cout<<"Stack overflow";
////	}
////	else
////	{ 
////		topElement++;
////		element[top] = value;
////	}
////
////}
////
////
////template<typename TypeElements>
////void Stack<TypeElements>::Pop(int numElemetToDelete)
////{
////	if (topElement==-1)
////	{
////		cout<<"stack is empty"
////	}
////	else
////	{
////		while (numElemetToDelete>0)
////		{
////			element[top]==0;
////			topElemnt--;
////			numElemetToDelete--;
////		}
////		
////	}
////}
////
////template<typename TypeElements>
////void Stack<TypeElements>::Show()
////{
////	for (int i=sizeSteck-1;i>=0;i--)
////	{
////		cout<<element[i]<<" ";
////	}
////	cout<<"\n";
////}