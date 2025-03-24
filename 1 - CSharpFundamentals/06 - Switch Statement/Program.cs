// Standard case statement, without pattern matching

int coffeeSize = 3;

switch (coffeeSize)
{
    case 1:
        Console.WriteLine("Small coffee");
        break;
    case 2:
        Console.WriteLine("Medium coffee");
        break;
    case 3:
        Console.WriteLine("Large coffee");
        break;
    default:
        Console.WriteLine("Unknown coffee size");
        break;
}