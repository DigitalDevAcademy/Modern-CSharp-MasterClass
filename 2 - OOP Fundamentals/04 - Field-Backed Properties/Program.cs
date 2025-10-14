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
    private string _someBackingField = "Some Value";

    public string SomeProperty
    {
        get { return _someBackingField; }
        set { _someBackingField = string.IsNullOrWhiteSpace(value) ? _someBackingField : value; }
    }

    // public string SomeProperty
    // {
    //     get { return field; }
    //     set { field = string.IsNullOrWhiteSpace(value) ? field : value; }
    // }

    // Example 2 - showcases how backing fields are still needed in some cases
    private string _someField = "Some Value";

    private string _anotherField = "Another Value";

    public string SomeCompuatedProperty
    {
        get { return $"{_someField} {_anotherField}"; }
    }
}