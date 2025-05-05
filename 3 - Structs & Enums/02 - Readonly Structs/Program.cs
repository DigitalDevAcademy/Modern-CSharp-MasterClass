Point point1 = new(10, 10);
Console.WriteLine($"Point1 X: {point1.X}, Y: {point1.Y}.");
// Cannot change immutable property values
// point1.X = 20;
// point1.Y = 20;

/* 
 * Readonly structs available starting C# 7.2 .NET Core 2.1/Framework 4.7.2
 * We can use primary constructor for structs as well since C# 12 .NET 8
 */
public readonly struct Point(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;
}