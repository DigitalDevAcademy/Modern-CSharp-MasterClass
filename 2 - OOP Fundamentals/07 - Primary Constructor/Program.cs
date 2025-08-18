Robot robotOne = new();
robotOne.PrintRobotInfo();

Robot robotTwo = new("New Robot", "New Map");
robotTwo.PrintRobotInfo();

class Robot(string description, string map)
{
    public Robot() : this("Default Robot", string.Empty) { }
    
    public string Description { get; set; } = description;

    public string Map { get; set; } = map;

    public void PrintRobotInfo() => Console.WriteLine($"Description: {Description}, Map: {Map}");
}