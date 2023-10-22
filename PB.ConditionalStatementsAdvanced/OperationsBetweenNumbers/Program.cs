int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

double result = 0;
string resultType = string.Empty;

switch (operation)
{
	case '+':
		result = n1 + n2;
		if (result % 2 == 0)
		{
			resultType = "even";
		}
		else
		{
			resultType = "odd";
		}
		Console.WriteLine($"{n1} + {n2} = {result} - {resultType}");
		break;
	case '-':
		result = n1 - n2;

		if (result % 2 == 0)
		{
			resultType = "even";
		}
		else
		{
			resultType = "odd";
		}

        Console.WriteLine($"{n1} - {n2} = {result} - {resultType}");
        break;
	case '*':
		result = n1 * n2;

        if (result % 2 == 0)
        {
            resultType = "even";
        }
        else
        {
            resultType = "odd";
        }
		Console.WriteLine($"{n1} * {n2} = {result} - {resultType}");
        break;
	case '/':
		if (n2 == 0)
		{
			Console.WriteLine($"Cannot divide {n2} by zero");
		}
		else
		{
			result = (double)n1 / n2;

			Console.WriteLine($"{n1} / {n2} = {result:f2}");
		}
		break;
	case '%':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n2} by zero");
        }
        else
        {
            result = n1 % n2;
            Console.WriteLine($"{n1} % {n2} = {result}");
        }
        break;
    default:
		break;
}
