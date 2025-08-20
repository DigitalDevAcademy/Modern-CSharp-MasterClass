SomeClass someClass = new();
Console.WriteLine(someClass.SomeProperty);
someClass.SomeProperty = "New Value";
Console.WriteLine(someClass.SomeProperty);
Console.WriteLine(someClass.SomeReadOnlyProperty);
Console.WriteLine(someClass.SomeMethod("New Param Value"));

class SomeClass
{
    public SomeClass() => SomeProperty = "Default Value";
    
    private string _someField = string.Empty; 

    public string SomeProperty
    {
        get => _someField;
        set => _someField = value;
    }

    public string SomeReadOnlyProperty => "Default ReadOnly Value";

    public string SomeMethod(string someParam) => $"Property: {SomeReadOnlyProperty}, Param: {someParam}";
}