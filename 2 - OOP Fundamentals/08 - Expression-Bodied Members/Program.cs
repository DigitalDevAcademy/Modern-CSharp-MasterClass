SomeClass someClass = new();
Console.WriteLine(someClass.someProperty);
someClass.someProperty = "New Value";
Console.WriteLine(someClass.someProperty);
Console.WriteLine(someClass.someReadOnlyProperty1);
Console.WriteLine(someClass.someReadOnlyProperty2);
Console.WriteLine(someClass.someMethod());

public class SomeClass
{
    public SomeClass() => someProperty = "Default Value";
    
    private string _someField = string.Empty; 

    public string someProperty
    {
        get => _someField;
        set => _someField = value;
    }

    public string someReadOnlyProperty1 => "Some Read-Only Value";

    public string someReadOnlyProperty2 { get => "Another Read-Only Value"; }

    public string someMethod() => $"{someReadOnlyProperty1} {someReadOnlyProperty2}";
}