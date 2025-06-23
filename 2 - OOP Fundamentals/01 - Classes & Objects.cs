// Instantiating a new instance of a class using target-typed new expression form C# 9 .NET 5
Employee employee1 = new();
// You can also instantiate this way, but unless you have a good reason to do so use target-typed new expression
// Employee employee1 = new Employee();
// var employee1 = new Employee();

// You can instantiate many instances of a class, I am just instantiating one more to keep things simple
Employee employee2 = new();

// Create an empty class with default access modifier, no modifiers and no class members
class Employee
{
    // Class body
}
