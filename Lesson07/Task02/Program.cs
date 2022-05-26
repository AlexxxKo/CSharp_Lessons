// Собрать строку с числами от a до b, a >= b

string NumbersFor(int a, int b)
{
	string result = string.Empty;
	for (int i = a; i >= b; i--)
	{
		result += $"{i} ";
	}
	return result;
}

string NumbersRec(int a, int b)
{
	if (a > b) return $"{a} " + NumbersRec(a - 1, b);
	else return $"{a}";
}

Console.Clear();
Console.WriteLine(NumbersFor(10, 1));
Console.WriteLine(NumbersRec(10, 1));