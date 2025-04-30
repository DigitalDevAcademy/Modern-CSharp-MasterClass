SomeClass someClass = new();
Console.WriteLine(someClass.someProperty);
someClass.someProperty = "New Value";
Console.WriteLine(someClass.someProperty);
Console.WriteLine(someClass.someReadOnlyProperty);
Console.WriteLine(someClass.someMethod("New Param Value"));

public class SomeClass
{
    public SomeClass() => someProperty = "Default Value";
    
    private string _someField = string.Empty; 

    public string someProperty
    {
        get => _someField;
        set => _someField = value;
    }

    public string someReadOnlyProperty => "Default ReadOnly Value";

    public string someMethod(string someParam) => $"ReadOnly Property Value: {someReadOnlyProperty}, SomeParam Value: {someParam}.";
}