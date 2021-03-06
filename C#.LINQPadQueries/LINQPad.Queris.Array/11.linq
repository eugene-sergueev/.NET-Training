<Query Kind="Statements" />

//список свойств класса System.Array

int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
//Возвращает общее число элементов во всех измерениях массива в виде 32-битного целого
numbers.Length.Dump("Length");

//Возвращает количество измерений массива
numbers.Rank.Dump("Rank");

//Возвращает объект, который может быть использован для синхронизации доступа к массиву. 
//Для массивов – это сам массив
numbers.SyncRoot.Dump("SyncRoot");//Скорость доступа к свойствам System.Array не вызывает нареканий