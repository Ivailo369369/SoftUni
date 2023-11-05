int primeSum = 0;
int nonPrimeSum = 0;

string input;
while ((input = Console.ReadLine()) != "stop")
{
    int number = int.Parse(input);

    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    bool isPrime = true;

    if (number <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    if (isPrime)
    {
        primeSum += number;
    }
    else
    {
        nonPrimeSum += number;
    }
}

Console.WriteLine($"Sum of all prime numbers is {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is {nonPrimeSum}");
