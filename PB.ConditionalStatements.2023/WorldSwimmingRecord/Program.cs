double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timePerMeterInSeconds = double.Parse(Console.ReadLine());

double timeInSeconds = distanceInMeters * timePerMeterInSeconds;

int delays = (int)Math.Floor(distanceInMeters / 15);

double delaysInSeconds = delays * 12.5;

double totalTimeInSeconds = timeInSeconds + delaysInSeconds;

if (totalTimeInSeconds < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeInSeconds:F2} seconds.");
}
else
{
    double neededSeconds = totalTimeInSeconds - recordInSeconds;

    Console.WriteLine($"No, he failed! He was {neededSeconds:F2} seconds slower.");
}
