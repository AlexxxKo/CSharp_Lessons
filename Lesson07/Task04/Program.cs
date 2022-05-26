// Факториал числа

double FactorialFor(int n)
{
	double result = 1;
	for (int i = 1; i <= n; i++) result *= i;
	return result;
}

double FactorialRec(int n)
{
	if (n == 1 || n == 0) return 1;
	else return n * FactorialRec(n - 1);
}

Console.Clear();
Console.WriteLine(FactorialFor(20));
Console.WriteLine(FactorialRec(3));