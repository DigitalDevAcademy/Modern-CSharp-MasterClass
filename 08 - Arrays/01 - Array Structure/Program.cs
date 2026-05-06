// All index-based access is O(1) time and space

int[] array = new int[10];
array[0] = 100;
array[9] = 900;

Console.WriteLine(array[0]);
Console.WriteLine(array[9]);
Console.WriteLine(array[array.Length - 1]);
Console.WriteLine(array[1]); // This shows the default value

// array[-1] = 1; // Will get an IndexOutOfRangeException
// array[10] = 1; // Will get an IndexOutOfRangeException

// Using collection expressions available since C# 12 .NET 8
int[] simpleArray = [1, 2, 3, 4, 5];

Console.WriteLine(simpleArray[0]);
Console.WriteLine(simpleArray[4]);

Element[] elementArray = [ new Element(10), new Element(20), new Element(50) ];
Console.WriteLine(elementArray[0].Value);
Console.WriteLine(elementArray[1].Value);
Console.WriteLine(elementArray[2].Value);

class Element(int value) { public int Value { get; init; } = value; }