// Игра в пирамидки

int i = 0;
void Towers(string with = "1", string on = "3", string some = "2", int count = 9)
{
	if (count > 1) Towers(with, some, on, count - 1);
	Console.WriteLine($"{i++}  {with} >> {on}");
	if (count > 1) Towers(some, on, with, count - 1);
}

Console.Clear();
Towers();
