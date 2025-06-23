Point point = new(10, 10);
object boxedPoint = point; // Boxing
Point unboxedPoint = (Point)boxedPoint; // Unboxing
unboxedPoint.Print();

IPrintable printableBoxedPoint = point; // Boxing
Point printableUnboxedPoint = (Point)printableBoxedPoint; // Unboxing
printableUnboxedPoint.Print();

readonly struct Point(int x, int y) : IPrintable
{
    public int X { get; init; } = x;

    public int Y { get; init; } = y;

    public void Print() => Console.WriteLine($"Printing point ({X}, {Y}).");
}

interface IPrintable
{
    void Print();
}


