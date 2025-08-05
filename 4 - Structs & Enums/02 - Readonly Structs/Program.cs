Point point = new(10, 10);
Console.WriteLine(point.GetInfo());
// Cannot change immutable property values
// point1.X = 20;
// point1.Y = 20;

readonly struct Point
{
    public int X { get; init; }
    public int Y { get; init; }

    // We can also use immutable fields
    // public readonly int X;
    // public readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}.";
}