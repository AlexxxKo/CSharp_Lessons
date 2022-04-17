int[] array = { 15, 21, 39, 12, 23, 33, 13, 12, 32 };

int n = array.Length;
int find = 12;

int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}