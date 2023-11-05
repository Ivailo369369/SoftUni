int n = int.Parse(Console.ReadLine());

for (int i = 1111; i <= 9999; i++)
{
    int number = i;
    bool isSpecial = true;

    while (number > 0)
    {
        int digit = number % 10;
        if (digit == 0 || n % digit != 0)
        {
            isSpecial = false;
            break;
        }

        number /= 10;
    }

    if (isSpecial)
    {
        Console.Write(i + " ");
    }
}
