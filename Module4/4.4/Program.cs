string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n");

Console.WriteLine($"Currently, you own {currentShares:N} at a return of {currentReturn:P2}.\r\n");

Console.WriteLine("Here's a quick comparison:\n");


string comparisonMessage = "";

// Your logic here
comparisonMessage = string.Format("{0} {1} {2}\r\n{3} {4} {5}", currentProduct.PadRight(20), currentReturn.ToString("P").PadRight(9), currentProfit.ToString("C"), newProduct.PadRight(20), newReturn.ToString("P").PadRight(9), newProfit.ToString("C"));

Console.WriteLine(comparisonMessage);