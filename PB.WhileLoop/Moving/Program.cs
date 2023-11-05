int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int totalVolume = width * lenght * height;

string input = Console.ReadLine();

while (input != "Done")
{
    int boxes = int.Parse(input);
    totalVolume -= boxes;

    if (totalVolume < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(totalVolume)} Cubic meters more.");
        break;
    }

    input = Console.ReadLine();
}

if (totalVolume > 0)
{
    Console.WriteLine($"{totalVolume} Cubic meters left.");
}
