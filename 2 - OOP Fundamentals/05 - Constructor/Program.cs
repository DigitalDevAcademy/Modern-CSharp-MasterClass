Robot robotOne = new();
Console.WriteLine($"Robot Info: {robotOne.Description}, {robotOne.Map}");

Robot robotTwo = new("New Robot", "New Map");
Console.WriteLine($"Robot Info: {robotTwo.Description}, {robotTwo.Map}");

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
        // Usually perform validation here
        // If description is invlaid do something, throw exception/set default value/etc
        // If map is invlaid something, throw exception/set default value/etc

        Description = description;
        Map = map;
    }
}