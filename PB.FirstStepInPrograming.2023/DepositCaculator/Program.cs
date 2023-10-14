double amountDeposited = double.Parse(Console.ReadLine());
int termOfDeposit = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine()) / 100;

double result = amountDeposited + termOfDeposit * (amountDeposited * annualInterestRate / 12);

Console.WriteLine(result);
