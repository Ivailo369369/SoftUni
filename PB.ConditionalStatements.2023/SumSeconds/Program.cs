int firstTime = int.Parse(Console.ReadLine());
int secondTIme = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalTime = firstTime + secondTIme + thirdTime;

int minutes = totalTime / 60;
int seconds = totalTime % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}
