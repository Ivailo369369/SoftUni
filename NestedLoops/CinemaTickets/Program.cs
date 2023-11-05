int studentTicketsCount = 0;
int standardTicketsCount = 0;
int kidTicketsCount = 0;

string movieName;

while ((movieName = Console.ReadLine()) != "Finish")
{
    int freeSeats = int.Parse(Console.ReadLine());

    int takenSeats = 0;
    string ticketType;

    while (takenSeats < freeSeats && (ticketType = Console.ReadLine()) != "End")
    {
        takenSeats++;

        switch (ticketType)
        {
            case "student":
                studentTicketsCount++;
                break;
            case "standard":
                standardTicketsCount++;
                break;
            case "kid":
                kidTicketsCount++;
                break;
            default:
                break;
        }
    }

    double projectionPercentage = ((double)takenSeats / freeSeats) * 100;

    Console.WriteLine($"{movieName} - {projectionPercentage:f2}% full.");
}

int totalTicketsCount = studentTicketsCount + standardTicketsCount + kidTicketsCount;
double studentPercentage = ((double)studentTicketsCount / totalTicketsCount) * 100;
double standartPercentage = ((double)standardTicketsCount / totalTicketsCount) * 100;
double kidPercentage = ((double)kidTicketsCount / totalTicketsCount) * 100;

Console.WriteLine($"Total tickets: {totalTicketsCount}");
Console.WriteLine($"{studentPercentage:f2}% student tickets.");
Console.WriteLine($"{standartPercentage:f2}% standard tickets.");
Console.WriteLine($"{kidPercentage:f2}% kids tickets.");
