// Как посмотреть содержимое папки?

// --------------------------------
// string path = "H:/Learn/GeekBrains/006 Знакомство с языками программирования (лекции)/CSharp_Lessons/";
// DirectoryInfo di = new DirectoryInfo(path);

// Console.Clear();
// Console.WriteLine(di.CreationTime);

// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
// 	Console.WriteLine(fi[i].Name);
// }

// --------------------------------
void CatalogInfo(string path, string indent = "")
{
	DirectoryInfo catalog = new DirectoryInfo(path);
	DirectoryInfo[] catalogs = catalog.GetDirectories();
	for (int i = 0; i < catalogs.Length; i++)
	{
		Console.WriteLine($"{indent}{catalogs[i].Name}");
		CatalogInfo(catalogs[i].FullName, indent + " ");
	}

	FileInfo[] files = catalog.GetFiles();

	for (int i = 0; i < files.Length; i++)
	{
		Console.WriteLine($"{indent}{files[i].Name}");
	}
}
string path = "H:/Learn/GeekBrains/006 Знакомство с языками программирования (лекции)/CSharp_Lessons/";
Console.Clear();
CatalogInfo(path);