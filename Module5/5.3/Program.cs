using System.IO.Compression;
using System.Reflection.Metadata;
using System.Xml.XPath;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    bool play = false;
    string? userEntry;

    userEntry = Console.ReadLine();

    if (userEntry != null)
    {
        userEntry = userEntry.ToLower().Trim();
    }
    if (userEntry == "y")
    {
        play = true;
    }
    else
    {
        play = false;
    }

    return play;
}

string WinOrLose(int target, int roll)
{
    string result = "";
    if (roll > target)
    {
        result = "You win!";
    }
    else 
    {
        result  = "You lose! Try again.";
    }

    return result;
}