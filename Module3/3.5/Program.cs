/* Battle challenge
int heroHP = 10;
int monsterHP = 10;
bool battleOn = true;
Random attack = new Random();

while (battleOn == true)
{
    int damage = attack.Next(1,11);
    monsterHP -= damage;
    Console.WriteLine($"Hero deals {damage} damage to monster.  Monster is left with {monsterHP} HP.");

    if (monsterHP > 0)
    {
        damage = attack.Next(1,11);
        heroHP -= damage;
        Console.WriteLine($"Monster deals {damage} damage to hero.  Hero is left with {heroHP} HP.");
    }

    if (monsterHP <= 0)
    {
        battleOn = false;
        Console.WriteLine($"Monster is defeated!  Hero wins!");
    } 
    else if (heroHP <= 0)
    {
        battleOn = false;
        Console.WriteLine($"Hero is defeated!  Monster wins!");
    }
}
*/
// Code Project 1
/*
int userInput = 0;

Console.WriteLine("Please enter an integer between 5 and 10.");

do
{
    try
    {
        int.TryParse(Console.ReadLine(), out userInput);
    }
    catch
    {
        Console.WriteLine("Please enter an integer.");
    }

    if (userInput < 5 || userInput > 10){
        Console.WriteLine($"{userInput} is not between 5 and 10.  Please enter a number between 5 and 10");

    }

}  while (userInput < 5 || userInput > 10);

Console.WriteLine($"Thank you. Your input of {userInput} is valid.");
*/

// Code Project 2
/*
string? userInput;
string option1 = "administrator";
string option2 = "manager";
string option3 = "user";
bool loopControl = true;
Console.WriteLine("Please select administrator, manager or user.");

while (loopControl == true)
{
    userInput = Console.ReadLine().Trim().ToLower();

    if (userInput != option1 && userInput != option2 && userInput != option3)
    {
        Console.WriteLine("Please enter a valid selection.");
    } 
    else
    {
        loopControl = false;
    }
}

Console.WriteLine($"Thank you! Your entry is accepted.");
*/

//Code Project 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;
string myString = "";

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    
    string stringToPrint;

    while (periodLocation != -1)
    {
        stringToPrint = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation +1);
        myString = myString.TrimStart();

        periodLocation = myString.IndexOf('.');

        Console.WriteLine(stringToPrint);
    }
    
    stringToPrint = myString.Trim();
    Console.WriteLine(stringToPrint);

}
