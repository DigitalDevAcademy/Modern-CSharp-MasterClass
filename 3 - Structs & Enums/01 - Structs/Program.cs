Point point1 = new();
Console.WriteLine(point1.GetInfo());
point1.X = 20;
point1.Y = 20;
Console.WriteLine(point1.GetInfo());

Point point2 = new(30, 30);
Console.WriteLine(point1.GetInfo());

Point point3 = new() { X = 40, Y = 40 };
Console.WriteLine(point1.GetInfo());

Point point4 = new(50);
Console.WriteLine(point1.GetInfo());

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Parameterless struct constructor available starting from C# 10 .NET 6
    public Point()
    {
        X = 10;
        Y = 10;
    }

    // Auto-default struct feature allows us to only set some properties and not all starting from C# 11 .NET 7
    public Point(int x) => X = x;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}.";
}