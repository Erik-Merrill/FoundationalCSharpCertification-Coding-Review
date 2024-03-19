using System.Net.Mime;

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayEmailAddress(i, corporate);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayEmailAddress(i, external, externalDomain);
}

void DisplayEmailAddress(int index, string[,] names, string domain = "contoso.com")
{
    string username = "";
        username = names[index,0].Remove(2).ToLower() + names[index,1].ToLower();
        Console.WriteLine($"{username}.{domain}"); 

}