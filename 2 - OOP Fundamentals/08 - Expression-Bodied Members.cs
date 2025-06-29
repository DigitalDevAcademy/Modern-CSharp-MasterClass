﻿SomeClass someClass = new();
Console.WriteLine(someClass.SomeProperty);
someClass.SomeProperty = "New Value";
Console.WriteLine(someClass.SomeProperty);
Console.WriteLine(someClass.someReadOnlyProperty);
Console.WriteLine(someClass.someMethod("New Param Value"));

class SomeClass
{
    public SomeClass() => SomeProperty = "Default Value";
    
    private string _someField = string.Empty; 

    public string SomeProperty
    {
        get => _someField;
        set => _someField = value;
    }

    public string someReadOnlyProperty => "Default ReadOnly Value";

    public string someMethod(string someParam) => $"ReadOnly Property Value: {someReadOnlyProperty}, SomeParam Value: {someParam}.";
}