Point point1 = new();
Console.WriteLine($"Point1 X: {point1.X}, Y: {point1.Y}.");
// Cannot change immutable property values
// point1.X = 10;
// point1.Y = 10; 

Point point2 = new(20, 20);
Console.WriteLine($"Point2 X: {point2.X}, Y: {point2.Y}.");

Point point3 = new() { X = 30, Y = 30 };
Console.WriteLine($"Point2 X: {point3.X}, Y: {point3.Y}.");

// Readonly structs available starting C# 7.2 .NET Core 2.1/Framework 4.7.2
public readonly struct Point
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point()
    {
        X = 0;
        Y = 0;
    }
    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}