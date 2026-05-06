object number = 10;
object text = "Hello World";
object person = new Person("John", "Doe");
object point = new Point(10, 10);

Console.WriteLine(number);
Console.WriteLine(text);
Console.WriteLine(person);
Console.WriteLine(point);

class Person(string firstName, string lastName)
{
    public string FirstName { get; init; } = firstName;

    public string LastName { get; init; } = lastName;
    
    public override string ToString() => $"FirstName {FirstName} and LastName {LastName}";
}

struct Point(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;

    public override string ToString() => $"X {X} and Y {Y}";
}