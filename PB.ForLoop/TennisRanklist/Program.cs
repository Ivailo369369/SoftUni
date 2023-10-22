int tournamentsCount = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

int totalTournamentsPoints = 0;
int totalWins = 0;

for (int i = 0; i < tournamentsCount; i++)
{
	string tournamentsResult = Console.ReadLine();

	switch (tournamentsResult)
	{
		case "W":
			totalTournamentsPoints += 2000;
			totalWins++;
			break;
		case "F":
			totalTournamentsPoints += 1200;
			break;
		case "SF":
			totalTournamentsPoints += 720;
			break;
		default:
			break;
	}
}

int totalPoints = initialPoints + totalTournamentsPoints;
double averagePoints = (double)totalTournamentsPoints / tournamentsCount;
double winPercentage = (double)totalWins / tournamentsCount * 100;

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{winPercentage:f2}%");
