<Query Kind="Program" />

void Main()
{

}

class X { }

class B { }

class D : B
{
	public static void X() { }
	
	public static void Y()
	{
		//однозначное раннее связывание
		X();
	}
}

//"Cвязывание" – это ассоциация синтаксического элемента, 
//содержащего имя метода, с логической частью программы.

//"Cвязывание" – это любая ассоциация некоторого фрагмента
//синтаксического дерева с некоторым логическим элементом программы