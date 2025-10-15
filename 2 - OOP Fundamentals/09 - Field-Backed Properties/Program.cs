SomeClass someClass = new();
Console.WriteLine(someClass.SomeProperty);
someClass.SomeProperty = string.Empty;
Console.WriteLine(someClass.SomeProperty);
someClass.SomeProperty = "Another Value";
Console.WriteLine(someClass.SomeProperty);
Console.WriteLine(someClass.SomeCompuatedProperty);

class SomeClass
{
    // Example 1
    private string _someBackingField;

    public SomeClass() => _someBackingField = "Some Value";

    public string SomeProperty
    {
        get => _someBackingField;
        set => _someBackingField = string.IsNullOrWhiteSpace(value) ? _someBackingField : value;
    }

    // public string SomeProperty
    // {
    //     get;
    //     set => field = string.IsNullOrWhiteSpace(value) ? field : value;
    // }

    // Example 2 - showcases the need for fields
    private string _someField = "Some Value";
    private string _anotherField = "Another Value";

    public string SomeCompuatedProperty => $"{_someField} {_anotherField}";
}