// Вид 1 - метод не принимает и не возвращает данные
// void Method1()
// {
// 	Console.WriteLine("Автор...");
// }
// // Method1();

// =============================

// Вид 2 - Метод принмает, но не возвращает данные
// void Method2(string msg)
// {
// 	Console.WriteLine(msg);
// }
// // Method2("Текст сообщения");
// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
// 	int i = 0;
// 	while (i < count)
// 	{
// 		Console.WriteLine(msg);
// 		i++;
// 	}
// }
// // Method21("Текст", 4);
// // Method21(msg: "Текст", count: 4);
// // Method21(count: 4, msg: "Текст");

// =============================

// Вид 3 - Метод не принимает, но возвращает данные
// int Method3()
// {
// 	return DateTime.Now.Year;
// }

// // int year = Method3();
// // Console.WriteLine(year);

// =============================

// Вид 4 - Метод и принимает, и возвращает данные
// string Method4(int count, string text)
// {
// 	int i = 0;
// 	// string result = "";
// 	string result = String.Empty;

// 	while (i < count)
// 	{
// 		result = result + text;
// 		i++;
// 	}

// 	return result;
// }

// string res = Method4(10, "asdf ");
// Console.WriteLine(res);

// =============================

// FOR
// string Method4(int count, string text)
// {
// 	string result = String.Empty;

// 	for(int i = 0; i < count; i++)
// 	{
// 		result += text;
// 	}

// 	return result;
// }

// string res = Method4(10, "asdf ");
// Console.WriteLine(res);

// =============================

// цикл в цикле
// for (int i = 1; i <= 10; i++)
// {
// 	for (int j = 1; j <= 10; j++)
// 	{
// 		Console.WriteLine($"{i} x {j} = {i * j}");
// 	}
// 	Console.WriteLine();
// }

// =============================

// Дан текст. В тексте нужно все пробелы заменить чёрточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
// 							+ "ежели бы вас послали вместо нашего милого Виценгероде, "
// 							+ "вы бы взяли приступом согласие прусского короля. "
// 							+ "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //						 012345
// // s[3] == r

// string Replace(string text, char oldValue, char newValue)
// {
// 	string result = String.Empty;

// 	int length = text.Length;
// 	for (int i = 0; i < length; i++)
// 	{
// 		if(text[i] == oldValue) result += $"{newValue}";
// 		else result += $"{text[i]}";

// 	}

// 	return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);

// =============================

// Упорядочить массив
// Метод минимакса

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosition = i;

		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] < array[minPosition]) minPosition = j;
		}

		int temporary = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temporary;
	}
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);