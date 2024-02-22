string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;
string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
Console.WriteLine(comparisonMessage);

comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
Console.WriteLine(comparisonMessage);

comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);
Console.WriteLine(comparisonMessage);