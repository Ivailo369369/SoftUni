string favoriteBook = Console.ReadLine();

int counter = 0;
bool isBookFound = false;
string nextBookName;

while ((nextBookName = Console.ReadLine()) != "No More Books")
{
	if (nextBookName == favoriteBook)
	{
		isBookFound = true;

		break;
	}

	counter++;
}

if (isBookFound)
{
	Console.WriteLine($"You checked {counter} books and found it.");
}
else
{
	Console.WriteLine("The book you search is not here!");
	Console.WriteLine($"You checked {counter} books.");
}
