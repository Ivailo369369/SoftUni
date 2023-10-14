double nylonPricePerSqMeter = 1.50;
double paintPricePerLiter = 14.50;
double thinnerPricePerLiter = 5.00;
double bagPrice = 0.40;

int nylonQuantity = int.Parse(Console.ReadLine());
int paintQuantity = int.Parse(Console.ReadLine());
int thinnerQuantity = int.Parse(Console.ReadLine());
int hoursOfWork = int.Parse(Console.ReadLine());

double extraPaint = paintQuantity * 0.10;
double extraNylon = 2.0;

double materialsTotalCost = (nylonQuantity + extraNylon) * nylonPricePerSqMeter +
                   (paintQuantity + extraPaint) * paintPricePerLiter +
                   thinnerQuantity * thinnerPricePerLiter + 
                   bagPrice;

double laborCost = (materialsTotalCost * 0.30) * hoursOfWork;

double totalCost = materialsTotalCost + laborCost;

Console.WriteLine(totalCost);