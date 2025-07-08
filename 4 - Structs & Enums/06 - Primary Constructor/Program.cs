Point point = new(10, 10);
Console.WriteLine(point.GetInfo());

// C# 12 .NET 8 introduced primary constructor for structs (and few other types)
readonly struct Point(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;

    public string GetInfo() => $"X is {X}, Y is {Y}.";
}