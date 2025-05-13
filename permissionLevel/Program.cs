string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level >  55)
    {
        Console.WriteLine("Welcome, <super.admin.user>");
    }
    else
    {
        Console.WriteLine("Welcome, <admin.user>");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You don't have sufficient privileges.");
}