Point point = new();
Console.WriteLine(point.GetInfo());

readonly struct Point
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point()
    {
        X = 10;
        Y = 10;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}.";
}