////string flowerType = Console.ReadLine();
////int flowersCount = int.Parse(Console.ReadLine());
////int budget = int.Parse(Console.ReadLine());

////double totalPrice = 0;

////switch (flowerType)
////{
////	case "Roses":
////		totalPrice = flowersCount * 5;

////		if (flowersCount > 80)
////		{
////			totalPrice -= totalPrice * 0.1;
////		}
////		break;
////	case "Dahlias":
////		totalPrice = flowersCount * 3.80;

////		if (flowersCount > 90)
////		{
////			totalPrice -= totalPrice * 0.15;
////		}
////		break;
////	case "Tulips":
////		totalPrice = flowersCount * 2.80;

////		if (flowersCount > 80)
////		{
////			totalPrice -= totalPrice * 0.15;
////		}
////		break;
////	case "Narcissus":
////		totalPrice = flowersCount * 3;

////		if (flowersCount < 120)
////		{
////			totalPrice += totalPrice * 0.15;
////		}
////		break;
////	case "Gladiolus":
////		totalPrice = flowersCount * 2.50;

////		if (flowersCount < 80)
////		{
////			totalPrice += totalPrice * 0.20;
////		}
////        break;
////    default:
////		break;
////}

////if (totalPrice <= budget)
////{
////	double remainingBudget = budget - totalPrice;
////	Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {remainingBudget:F2} leva left.");
////}
////else
////{
////	double neededMoney = totalPrice - budget;
////	Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
////}

//string flowertype = Console.ReadLine();
//int flowers = int.Parse(Console.ReadLine());
//int budget = int.Parse(Console.ReadLine());

//double totalprice = 0;

//switch (flowertype)
//{
//    case "Roses":
//        totalprice = flowers * 5;

//        if (flowers > 80)
//        {
//            totalprice -= totalprice * 0.1;
//        }
//        break;
//    case "Dahlias":
//        totalprice = flowers * 3.80;

//        if (flowers > 80)
//        {
//            totalprice -= totalprice * 0.15;
//        }
//        break;
//    case "Tulips":
//        totalprice = flowers * 2.80;

//        if (flowers > 80)
//        {
//            totalprice -= totalprice * 0.15;
//        }
//        break;
//    case "Narcissus":
//        totalprice = flowers * 3;

//        if (flowers < 120)
//        {
//            totalprice += totalprice * 0.15;
//        }
//        break;
//    case "Gladiolus":
//        totalprice = flowers * 2.50;

//        if (flowers < 120)
//        {
//            totalprice += totalprice * 0.20;
//        }
//        break;
//    default:
//        break;
//}

//if (totalprice <= budget)
//{
//    double remainingbudget = budget - totalprice;
//    Console.WriteLine($"Hey, you have a great garden with {flowers} {flowertype} and {remainingbudget:F2} leva left.");
//}
//else
//{
//    double neededmoney = totalprice - budget;
//    Console.WriteLine($"Not enough money, you need {neededmoney:F2} leva more.");
//}

double n1 = int.Parse(Console.ReadLine());
double n2 = int.Parse(Console.ReadLine());
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
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            result = n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {result:f2}");
        }
        break;

    case '%':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            result = n1 % n2;
            Console.WriteLine($"{n1} % {n2} = {result}");
        }
        break;
}