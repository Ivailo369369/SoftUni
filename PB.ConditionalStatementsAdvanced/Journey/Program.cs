double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = string.Empty;
string vacationType = string.Empty;
double spentAmount = 0;

if (budget <= 100)
{
    destination = "Bulgaria";

    switch (season)
    {
        case "summer":
            vacationType = "Camp";
            spentAmount = budget * 0.3;
            break;
        case "winter":
            vacationType = "Hotel";
            spentAmount = budget * 0.7;
            break;
        default:
            break;
    }

    if (season == "summer")
    {
        Console.WriteLine("Pesho");
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        spentAmount = budget * 0.7;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";

    if (season == "summer")
    {
        vacationType = "Camp";
        spentAmount = budget * 0.4;
    }
    else if (season == "winter")
    {
        vacationType = "Hotel";
        spentAmount = budget * 0.8;
    }
}
else
{
    destination = "Europe";
    vacationType = "Hotel";
    spentAmount = budget * 0.9;
}

spentAmount = Math.Round(spentAmount);

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{vacationType} - {spentAmount:F2}");
