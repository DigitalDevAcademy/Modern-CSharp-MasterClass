MutablePoint mutablePoint = new(1, 1);
ChangePointWithRef(ref mutablePoint);
void ChangePointWithRef(ref MutablePoint point)
{
    point.X = 2;
    point.Y = 2;
}
Console.WriteLine($"{mutablePoint.X}, {mutablePoint.Y}");

/* 
 * Starting with C# 7.0 you can declare out variables inline
 * 
 * TryParse is a great example of a built-in method which converts 
 * the string representation of a number to its 32-bit signed integer equivalent 
 */ 
var isParsed = int.TryParse("10", out int result);
Console.WriteLine($"{isParsed} - {result}");

// Starting with C# 7.2 you can declare method params as read-only
var largeStruct = new LargeStruct(1000);

MethodRequiringGoodPerformance(in largeStruct);

void MethodRequiringGoodPerformance(in LargeStruct largeStruct) => Console.WriteLine($"Procesing {largeStruct.SomeAmount}.");

public readonly struct LargeStruct(int amount)
{
    public readonly int SomeAmount = amount;
    public readonly long A, B, C, D, E = 100;
}

public struct MutablePoint(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
}
