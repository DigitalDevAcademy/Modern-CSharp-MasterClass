Robot robot1 = new();
Console.WriteLine($"Robot 1: {robot1.Description}, {robot1.Map}");

Robot robot2 = new("New Robot", "New Map");
Console.WriteLine($"Robot 2: {robot2.Description}, {robot2.Map}");

class Robot
{
    public string Description { get; set; }

    public string Map { get; set; }

    public Robot()
    {
        Description = "Default Robot";
        Map = string.Empty;
    }

    public Robot(string description, string map)
    {
        Description = description;
        Map = map;
    }
}