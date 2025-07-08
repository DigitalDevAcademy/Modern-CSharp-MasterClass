// Instantiate frist Person object
Person person1 = new() 
{
    name = "SomePerson1"
    // _ssn = "abc123" // Cannot access _ssn, it is a private field
};
Console.WriteLine($"Person 1 name: {person1.name}");

// Instantiate second Person object
Person person2 = new()
{
    name = "SomePerson2",
    // _ssn = "abc456"; // Cannot access _ssn, it is a private field
};
Console.WriteLine($"Person 2 name: {person2.name}");

class Person
{
    public string name = string.Empty;

    /*
    * Students please ignore this "pragma" line here and at the bottom of the file
    * This is for suppressing warnings as it was intended to declare a field but never use it
    * in order to showcase how to write private fields in a class.
    */
    #pragma warning disable CS0414
    private string _ssn = string.Empty; // Cannot access or modify a private field anywhere else except the class itself
    #pragma warning restore CS0414
}