#include "TestClass.h"
#include <iostream>

template<typename T>
TestClass<T>::TestClass(int x)
	:x(x)
{
}

template<typename T>
void TestClass<T>::Print()
{
	std::cout << "Print " << x << "\n";
}