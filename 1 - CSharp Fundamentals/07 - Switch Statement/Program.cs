int userRole = 2;

switch (userRole)
{
    case 1:
        Console.WriteLine("Guest");
        break;
    case 2:
        Console.WriteLine("Member");
        break;
    case 3:
        Console.WriteLine("Admin");
        break;
    default:
        Console.WriteLine("Unknown user type");
        break;
}