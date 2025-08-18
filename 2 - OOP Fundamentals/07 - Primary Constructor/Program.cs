Robot robotOne = new();
robotOne.PrintRobotInfo();

Robot robotTwo = new("New Robot", "New Map");
robotTwo.PrintRobotInfo();

class Robot(string description, string map)
{
    public Robot() : this("Default Robot", string.Empty) { }
    
    /* 
     * Only use primary constructor parameters to initialize properties but
     * do not use them elsewhere in the class becasue it could create a double
     * backing field problem which could be confusing to troubleshoot
     */
    public string Description { get; init; } = description;

    public string Map { get; set; } = map;


    public void PrintRobotInfo() 
    {
        /* 
         * Here I am using initialized properties instead of primary constructor parameters
         * Even though I could use primary constructor parameters I am not using them 
         * to avoid double backing field issues
         */
        Console.WriteLine($"Description: {Description}, Map: {Map}");
    }
}