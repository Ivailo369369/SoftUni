int dailyGoalSteps = 10000;
int totalSteps = 0;

while (true)
{
	string input = Console.ReadLine();

	if (input == "Going home")
	{
		int stepsOnTheWayHome = int.Parse(Console.ReadLine());
		totalSteps += stepsOnTheWayHome;

		if (totalSteps >= dailyGoalSteps)
		{
			int stepsOverTheGoal = totalSteps - dailyGoalSteps;

			Console.WriteLine("Goal reached! Good job!");
			Console.WriteLine($"{stepsOverTheGoal} steps over the goal!");
		}
		else
		{
			int stepsRemaining = dailyGoalSteps - totalSteps;

			Console.WriteLine($"{stepsRemaining} more steps to reach goal.");
		}

		break;
	}

	int steps = int.Parse(input);
	totalSteps += steps;

	if (totalSteps >= dailyGoalSteps)
	{
        int stepsOverTheGoal = totalSteps - dailyGoalSteps;

        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{stepsOverTheGoal} steps over the goal!");

		break;
    }
}