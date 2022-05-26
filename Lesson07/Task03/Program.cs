// Сумма чисел от 1 до n

int SumFor(int n)
{
	int result = 0;
	for (int i = 1; i <= n; i++) result += i;
	return result;
}

int SumRec(int n)
{
	if (n == 1) return n;
	else return n + SumRec(n - 1);
}

Console.Clear();
Console.WriteLine(SumFor(100));
Console.WriteLine(SumRec(100));