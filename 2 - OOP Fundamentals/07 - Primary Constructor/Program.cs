Robot robotOne = new();
Console.WriteLine($"Robot Info: {robotOne.Name}, {robotOne.Map}");

Robot robotTwo = new("New Robot", "New Map");
Console.WriteLine($"Robot Info: {robotTwo.Name}, {robotTwo.Map}");

public class Robot(string name, string map)
{
    public Robot() : this("Unnamed Robot", "") { }
    
    public string Name { get; init; } = name;

    public string Map { get; set; } = map;
}