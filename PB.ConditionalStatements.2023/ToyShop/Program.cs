double puzzlePrice = 2.60;
double dollPrice = 3.00;
double teddyBearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2.00;

double excursionPrice = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int teddyBears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double totalCost = (puzzles * puzzlePrice) +
        (dolls * dollPrice) +
        (teddyBears * teddyBearPrice) +
        (minions * minionPrice) +
        (trucks * truckPrice);

int totalToys = puzzles + dolls + teddyBears + minions + trucks;

if (totalToys >= 50)
{
    totalCost -= totalCost * 0.25;
}

totalCost -= totalCost * 0.10;

if (totalCost >= excursionPrice)
{
    double leftMoney = totalCost - excursionPrice;

    Console.WriteLine($"Yes! {leftMoney:F3} lv lef");
}
else
{
    double neededMoney = excursionPrice - totalCost;

    Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed");
}
