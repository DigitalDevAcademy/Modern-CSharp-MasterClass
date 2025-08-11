Robot robotOne = new();
Console.WriteLine($"Robot Info: {robotOne.Name}, {robotOne.Map}");

Robot robotTwo = new("New Robot", "New Map");
Console.WriteLine($"Robot Info: {robotTwo.Name}, {robotTwo.Map}");

class Robot
{
    public string Name { get; init; }

    public string Map { get; set; }

    public Robot()
    {
        Name = "Default Robot";
        Map = string.Empty;
    }

    public Robot(string name, string map)
    {
        Name = name;
        Map = map;
    }
}