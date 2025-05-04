Point point1 = new();
Console.WriteLine($"Point1 X: {point1.X}, Y: {point1.Y}.");
point1.X = 10;
point1.Y = 10;
Console.WriteLine($"Point1 X: {point1.X}, Y: {point1.Y}.");

Point point2 = new(20, 20);
Console.WriteLine($"Point2 X: {point2.X}, Y: {point2.Y}.");

Point point3 = new() { X = 30, Y = 30 };
Console.WriteLine($"Point2 X: {point3.X}, Y: {point3.Y}.");

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Parameterless struct constructor available starting from C# 10 .NET 6
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