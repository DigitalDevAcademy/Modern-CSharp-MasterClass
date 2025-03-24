// Standard if elseif else statement, without pattern matching

int coffeeSize = 2;
bool hasSugar = true;
bool hasMilk = false;

if (coffeeSize == 1 && hasMilk)
{
    Console.WriteLine("Small coffee with milk");
}
else if (coffeeSize == 2 && hasSugar)
{
    Console.WriteLine("Medium coffee with sugar");
}
else if (coffeeSize == 3 && hasSugar && hasMilk)
{
    Console.WriteLine("Large coffee with sugar and milk");
}
else
{
    Console.WriteLine("Unknown coffee size");
}