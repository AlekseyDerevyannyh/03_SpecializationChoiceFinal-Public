// **Задача**: Написать программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// **Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

using System;
using static System.Console;

Clear();
string[] arrayString = GetStringArrayFromConsole();
WriteLine();
PrintStringArray(arrayString);
Write(" -> ");
PrintStringArray(TrimStringLength3(arrayString));


string[] GetStringArrayFromConsole () {
	Write("Введите количество элементов строкового массива: ");
	int size;
	if(!int.TryParse(ReadLine(), out size)) {
		Write("Ошибка ввода!");
		return new string[]{""};
	}
	string[] result = new string[size];
	for (int i = 0; i < size; i ++) {
		Write($"Введите {i + 1} элемент строкового массива: ");
		result[i] = ReadLine();
	}
	return result;
}

string[] TrimStringLength3 (string[] array) {
	int resultSize = 0;
	for (int i = 0; i < array.Length; i ++) {
		if (array[i].Length <= 3)	resultSize ++;
	}
	if (resultSize == 0) return new string[]{""};

	string[] result = new string[resultSize];
	int resultIndex = 0;
	for (int i = 0; i < array.Length; i ++) {
		if (array[i].Length <=3) {
			result[resultIndex] = array[i];
			resultIndex ++;
		}
	}
	return result;
}

void PrintStringArray (string[] array) {
	Write("[");
	for (int i = 0; i < array.Length - 1; i ++) 
		Write($"{array[i]}, ");
	Write($"{array[array.Length - 1]}]");
}
