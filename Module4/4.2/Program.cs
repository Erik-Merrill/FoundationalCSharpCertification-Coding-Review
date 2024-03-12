/*
string[] values = { "12.3" , "45" , "ABC" , "11" , "DEF" };
decimal total = 0;
string message = "";

foreach (string value in values)
{
    decimal numericalStorage = 0;
    if (decimal.TryParse(value, out numericalStorage))
    {
        total += numericalStorage;
    }
    else {
        message += value;
    }
}

Console.WriteLine($"message = {message}");
Console.WriteLine($"total = {total}");
*/

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2;
decimal result2 = value2 / (decimal)value3;
float result3 = value3 / value1; 

Console.WriteLine($"Divide value 1 by value 2, display the result as an int: {result1}");
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
Console.WriteLine($"Divide value 3 by value 1, display the result as a float: {result3}");