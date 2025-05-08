DynamicPoint dynamicPoint = new();
Console.WriteLine(dynamicPoint.GetInfo());

public readonly struct DynamicPoint
{
    public int X { get; init; }
    public int Y { get; init; }
    public int Z { get; init; }      

    // C# 11 .NET 7 introduced auto-default structs
    public DynamicPoint()
    {
        X = 10;
        Y = 10;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}, Z is {Z}.";
}