using System.Security.Cryptography;

for (int i = 1; i <= 100; i++)
{
    string additional = "";

    if (i % 3 == 0 && i % 5 == 0)
    {
        additional = "FizzBuzz";
    }
    else if (i % 3 == 0)
    {
        additional = "Fizz";
    }
    else if (i % 5 == 0) 
    {
        additional = "Buzz";
    }
    Console.WriteLine($"{i} - {additional}");
}