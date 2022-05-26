// Перебор слов
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова,
// состоящие из T букв, которые можно построить из букв этого алфавита

// Console.Clear();
char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
	for (int j = 0; j < count; j++)
	{
		for (int k = 0; k < count; k++)
		{
			for (int l = 0; l < count; l++)
			{
				Console.WriteLine($"{n++,-4}{s[i]}{s[j]}{s[k]}{s[l]}");
			}
		}
	}
}

n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
	if (length == word.Length)
	{
		Console.WriteLine($"{n++} {new String(word)}");
		// Console.ReadKey();
		return;
	}
	for (int i = 0; i < alphabet.Length; i++)
	{
		word[length] = alphabet[i];
		FindWords(alphabet, word, length + 1);
	}
}

// Console.Clear();
FindWords("аисв", new char[4]);