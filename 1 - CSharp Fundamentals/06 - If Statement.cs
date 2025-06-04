// Standard if elseif else statement, without pattern matching

int userRole = 2;

if (userRole == 1)
{
    Console.WriteLine("Guest");
}
else if (userRole == 2)
{
    Console.WriteLine("Member");
}
else if (userRole == 3)
{
    Console.WriteLine("Admin");
}
else
{
    Console.WriteLine("Unknown user type");
}