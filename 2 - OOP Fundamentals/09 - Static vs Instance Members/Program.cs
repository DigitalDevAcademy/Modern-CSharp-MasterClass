AdditionHelper.Add(10);
Console.WriteLine(AdditionHelper.Result);

AdditionHelper.Add(10);
Console.WriteLine(AdditionHelper.Result);

// Static class cannot have any instance members only static members
public static class AdditionHelper
{
    // We can have static fields and properties, but I am only using a property to keep the example concise
    public static int Result { get; set; }

    static AdditionHelper() => Result = 0;

    public static void Add(int number) => Result += number;
}