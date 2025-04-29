Manager manager;

manager = new();
Console.WriteLine($"Manager Info: {manager.FullName}, {manager.Age}");

manager = new("John Doe");
Console.WriteLine($"Manager Info: {manager.FullName}, {manager.Age}");

manager = new("John Doe", 40);
Console.WriteLine($"Manager Info: {manager.FullName}, {manager.Age}");

public class Manager
{
    public string FullName { get; set; }

    public int Age { get; set; }

    // This is constructor chaining that can be used with the this keyword
    public Manager() : this("Default Name")
    {
    }

    // Showcasing multiple constructor chaining using the this keyword
    public Manager(string fullName) : this(fullName, 30)
    {
    }

    public Manager(string fullName, int age)
    {
        FullName = fullName;
        Age = age;
    }
}