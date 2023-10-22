int totalGroups = int.Parse(Console.ReadLine());

int musalaClimbers = 0;
int monthBlancClimbers = 0;
int kilimanjaroClimbers = 0;
int k2Climbers = 0;
int everestClimbers = 0;

for (int i = 0; i < totalGroups; i++)
{
    int groupSize = int.Parse(Console.ReadLine());

	if (groupSize <= 5)
	{
		musalaClimbers += groupSize;
	}
	else if (groupSize >= 6 && groupSize <= 12)
	{
		monthBlancClimbers += groupSize;
	}
	else if (groupSize >= 13 && groupSize <= 25)
	{
		kilimanjaroClimbers += groupSize;
	}
	else if (groupSize >= 26 && groupSize <= 40)
	{
		k2Climbers += groupSize;
	}
	else
	{
		everestClimbers += groupSize;
	}
}

int totalClimbers = musalaClimbers + monthBlancClimbers +
	kilimanjaroClimbers + k2Climbers + everestClimbers;

double musalaClimbersPercent = (double)musalaClimbers / totalClimbers * 100;
double monthBlacClimbersPercent = (double)monthBlancClimbers / totalClimbers * 100;
double kilimanjaroClimbersPercent = (double)kilimanjaroClimbers / totalClimbers * 100;
double k2ClimbersPercent = (double)k2Climbers / totalClimbers * 100;
double everestClimbersPercent = (double)everestClimbers / totalClimbers * 100;

Console.WriteLine($"{musalaClimbersPercent:f2}%");
Console.WriteLine($"{monthBlacClimbersPercent:f2}%");
Console.WriteLine($"{kilimanjaroClimbersPercent:f2}%");
Console.WriteLine($"{k2ClimbersPercent:f2}%");
Console.WriteLine($"{everestClimbersPercent:f2}%");