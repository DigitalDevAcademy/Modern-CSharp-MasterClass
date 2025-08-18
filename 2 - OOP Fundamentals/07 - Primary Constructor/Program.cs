Robot robot1 = new();
Console.WriteLine($"Robot 1: {robot1.Description}, {robot1.Map}");

Robot robot2 = new("New Robot", "New Map");
Console.WriteLine($"Robot 2: {robot2.Description}, {robot2.Map}");

class Robot(string description, string map)
{
    public Robot() : this("Default Robot", string.Empty) { }
    
    public string Description { get; set; } = description;

    public string Map { get; set; } = map;
}