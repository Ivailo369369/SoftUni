int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

int savedMoney = 0;
int toyCount = 0;
int moneyGift = 10;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        savedMoney += moneyGift - 1;
        moneyGift += 10;
    }
    else
    {
        toyCount++;
    }
}

int totalMoneyFromToys = toyCount * toyPrice;
int totalMoney = savedMoney + totalMoneyFromToys;

if (totalMoney >= washingMachinePrice)
{
    double remainingMoney = totalMoney - washingMachinePrice;
    Console.WriteLine($"Yes! {remainingMoney:f2}");
}
else
{
    double neededMoney = washingMachinePrice - totalMoney;
    Console.WriteLine($"No! {neededMoney:f2}");
}
