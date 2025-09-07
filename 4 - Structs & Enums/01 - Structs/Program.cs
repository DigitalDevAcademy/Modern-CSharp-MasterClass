Point point1 = new();
point1.X = 10;
point1.Y = 10;
Console.WriteLine(point1.GetInfo());

Point point2 = new(20, 20);
Console.WriteLine(point2.GetInfo());

Point point3 = new() { X = 30, Y = 30 };
Console.WriteLine(point3.GetInfo());

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}";
}