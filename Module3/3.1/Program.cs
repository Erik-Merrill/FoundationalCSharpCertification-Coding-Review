using System.Security;

string permission = "";
int level = 13;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else 
    {
        Console.WriteLine("Welcome, Admin user");
    }
} 
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact Admin for access.");
    }
    else 
    {
        Console.WriteLine("You do not have sufficient privileges.");    

    }
} 
else
{
        Console.WriteLine("You do not have sufficient privileges.");    
}
