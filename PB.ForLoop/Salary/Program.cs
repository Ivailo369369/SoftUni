int numberOfTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberOfTabs; i++)
{
    string website = Console.ReadLine();

	switch (website)
	{
		case "Facebook":
			salary -= 150;
			break;
		case "Instagram":
			salary -= 100;
			break;
		case "Reddit":
			salary -= 50;
			break;
		default:
			break;
	}

	if (salary == 0)
	{
		Console.WriteLine("You have lost your salary.");

		return;
	}
}

Console.WriteLine(salary);