int cakeWidth = int.Parse(Console.ReadLine());
int cakeLenght = int.Parse(Console.ReadLine());

int piecesTaken = 0;
int cakeSize = cakeWidth * cakeLenght;

string input = Console.ReadLine();
while (input != "STOP")
{
    int pieces = int.Parse(input);
    piecesTaken += pieces;

    if (piecesTaken >= cakeSize)
    {
        int neededPieces = piecesTaken - cakeSize;

        Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
        break;
    }

    input = Console.ReadLine();
}

int piecesLeft = cakeSize - piecesTaken;

if (piecesLeft > 0)
{
    Console.WriteLine($"{piecesLeft} pieces are left.");
}
