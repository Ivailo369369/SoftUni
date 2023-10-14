int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());

minute += 15;
hour += minute / 60;
minute %= 60;
hour %= 24;

if (minute >= 10)
{
    Console.WriteLine($"{hour}:{minute}");
}
else
{
    Console.WriteLine($"{hour}:0{minute}");
}
