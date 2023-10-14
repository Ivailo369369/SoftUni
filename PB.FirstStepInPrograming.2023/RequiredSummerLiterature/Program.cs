int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToRead = int.Parse(Console.ReadLine());

int hoursPerDay = pages / (pagesPerHour * daysToRead);

Console.WriteLine(hoursPerDay);