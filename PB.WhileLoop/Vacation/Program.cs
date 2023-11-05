double tripCost = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());

int totalDays = 0;
int spendingCounter = 0;

while (availableMoney < tripCost && spendingCounter < 5)
{
    string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());

    if (action == "save")
    {
        availableMoney += amount;
        spendingCounter = 0;
    }
    else if (action == "spend")
    {
        availableMoney -= amount;

        if (availableMoney < 0)
        {
            availableMoney = 0;
        }

        spendingCounter++;
    }

    totalDays++;
}

if (spendingCounter == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(totalDays);
}
else if (availableMoney >= tripCost)
{
    Console.WriteLine($"You saved the money for {totalDays} days.");
}