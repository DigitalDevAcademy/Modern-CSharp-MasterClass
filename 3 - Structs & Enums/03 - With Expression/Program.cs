Point point1 = new(10, 10);
Console.WriteLine($"Point1 X: {point1.X}, Y: {point1.Y}.");

// With expression available for structs starting C# 10 .NET 6
Point point2 = point1 with { X = 20 };
Console.WriteLine($"Point1 X: {point2.X}, Y: {point2.Y}.");

public readonly struct Point
{
    public int X { get; init; }
    public int Y { get; init; }
    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}