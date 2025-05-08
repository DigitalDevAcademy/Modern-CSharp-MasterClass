Point point1 = new();
Console.WriteLine(point1.GetInfo());

public readonly struct Point
{
    public int X { get; init; }
    public int Y { get; init; }

    // C# 10 .NET 6 introduced explicit parameterless constructor for structs
    public Point()
    {
        X = 10;
        Y = 10;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}.";
}