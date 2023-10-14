int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentOccupied = double.Parse(Console.ReadLine()) / 100;

double aquatiumVolume = lenght * width * height;
double volumeLiters = aquatiumVolume * 0.001;

double litersNeeded = volumeLiters * (1.0 - percentOccupied);

Console.WriteLine(litersNeeded);