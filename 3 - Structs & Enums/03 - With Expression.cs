Point point1 = new(10, 10);
Console.WriteLine(point1.GetInfo());

// Non-destructive mutation using with expression
Point point2 = point1 with { X = 20 };
Console.WriteLine(point2.GetInfo());

public readonly struct Point
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}.";
}