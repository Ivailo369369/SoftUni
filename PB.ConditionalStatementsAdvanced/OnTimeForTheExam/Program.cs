int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

int examTimeInMinutes = examHour * 60 + examMinute;
int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;

if (arrivalTimeInMinutes > examTimeInMinutes)
{
    Console.WriteLine("Late");

    int minutesLate = arrivalTimeInMinutes - examTimeInMinutes;

    if (minutesLate < 60)
    {
        Console.WriteLine($"{minutesLate} minutes after the start");
    }
    else
    {
        int hoursLate = minutesLate / 60;
        int remainningMinutes = minutesLate % 60;
        Console.WriteLine($"{hoursLate}:{remainningMinutes:D2} minutes after the start");
    }
}
else if (examTimeInMinutes - arrivalTimeInMinutes <= 30)
{
    Console.WriteLine("On time");

    int minutesEarly = examTimeInMinutes - arrivalTimeInMinutes;
    Console.WriteLine($"{minutesEarly} minutes before the start");
}
else
{
    Console.WriteLine("Early");

    int minutesEarly = examTimeInMinutes - arrivalTimeInMinutes;

    if (minutesEarly < 60)
    {
        Console.WriteLine($"{minutesEarly} minutes before the start");
    }
    else
    {
        int hoursEarly = minutesEarly / 60;
        int remainningMinutes = minutesEarly % 60;

        Console.WriteLine($"{hoursEarly}:{remainningMinutes:D2} before the start");
    }
}
