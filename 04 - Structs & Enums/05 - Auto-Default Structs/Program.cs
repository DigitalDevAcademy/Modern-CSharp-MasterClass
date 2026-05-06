DynamicPoint dynamicPoint = new();
Console.WriteLine(dynamicPoint.GetInfo());

readonly struct DynamicPoint
{
    public int X { get; init; }

    public int Y { get; init; }

    public int Z { get; init; }      

    public DynamicPoint()
    {
        X = 10;
        Y = 10;
    }

    public string GetInfo() => $"X is {X}, Y is {Y}, Z is {Z}";
}