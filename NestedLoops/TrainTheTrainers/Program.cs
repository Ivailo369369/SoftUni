int juryMembers = int.Parse(Console.ReadLine());

double totalScore = 0;
int presentationCount = 0;
string presentationName;

while ((presentationName = Console.ReadLine()) != "Finish")
{
    double presentationScore = 0;

	for (int i = 0; i < juryMembers; i++)
	{
		double score = double.Parse(Console.ReadLine());
		presentationScore += score;
	}

	double averageScore = presentationScore / juryMembers;
	totalScore += averageScore;
	presentationCount++;

	Console.WriteLine($"{presentationName} - {averageScore:f2}.");
}

double finalAssesment = totalScore / presentationCount;

Console.WriteLine($"Student's final assessment is {finalAssesment:f2}.");
