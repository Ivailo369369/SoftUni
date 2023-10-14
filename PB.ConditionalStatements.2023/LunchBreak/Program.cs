string seriesName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

double lunchTime = breakDuration * 1.0 / 8;
double restTime = breakDuration * 1.0 / 4;
double remainingTime = breakDuration - lunchTime - restTime;

if (remainingTime >= episodeDuration)
{
    int leftoverTime = (int)Math.Ceiling(remainingTime - episodeDuration);

    Console.WriteLine($"You have enough time to watch {seriesName} and left with {leftoverTime} minutes free time.");
}
else
{
    int neededTime = (int)Math.Ceiling(episodeDuration - remainingTime);
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {neededTime} more minutes.");
}
