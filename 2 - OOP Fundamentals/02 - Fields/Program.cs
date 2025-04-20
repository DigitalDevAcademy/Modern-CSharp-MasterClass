// Instantiate frist Employee object
var employee1 = new Employee();
employee1.name = "SomeEmployee1";
// employee1.salary = 100000; // Cannot access salary, it is a private field
Console.WriteLine($"Employee 1 name is {employee1.name}.");

// Instantiate second Employee object
var employee2 = new Employee();
employee2.name = "SomeEmployee2";
// employee2.salary = 100000; // Cannot access salary, it is a private field
Console.WriteLine($"Employee 2 name is {employee1.name}.");

public class Employee
{
    public string name = string.Empty;

    /*
    * Students please ignore this "pragma" line here and at the bottom of the file
    * This is for suppressing warnings as it was intended to declare a field but never use it
    * in order to showcase how to write private fields in a class.
    */
    #pragma warning disable CS0414
    private double salary = 0; // Cannot access or modify a private field anywhere else except the class itself
    #pragma warning restore CS0414
}