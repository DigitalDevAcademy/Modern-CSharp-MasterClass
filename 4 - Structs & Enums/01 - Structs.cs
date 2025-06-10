// We are calling an auto-generated parameterless default constructor
Point point1 = new();
point1.X = 10;
point1.Y = 10;
Console.WriteLine(point1.GetInfo());

// We are calling the explicit parameterized constructor
Point point2 = new(20, 20);
Console.WriteLine(point2.GetInfo());

/* 
 * We are calling an auto-generated parameterless default constructor
 * then using object initializer to set struct property values
 */
Point point3 = new() { X = 30, Y = 30 };
Console.WriteLine(point3.GetInfo());

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}.";
}