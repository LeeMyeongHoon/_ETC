#pragma once

template<typename T>
class TestClass
{
public:
	TestClass(int x);
	void Print();
private:
	int x;
};

#include "TestClass.cpp"