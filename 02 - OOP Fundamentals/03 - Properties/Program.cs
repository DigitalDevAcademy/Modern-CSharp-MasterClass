Bus bus = new() { Capacity = 50 };

Console.WriteLine(bus.Name);
bus.Name = "Some Bus Name";
Console.WriteLine(bus.Name);
bus.Name = string.Empty;
Console.WriteLine(bus.Name);
bus.Operator = "Some Operator";
Console.WriteLine(bus.Operator);
bus.Operator = "Another Operator";
Console.WriteLine(bus.Operator);
// bus.Capacity = 100; // Cannot modify Capacity property because it is immutable
Console.WriteLine(bus.Capacity);
// bus.Manufacturer = "Another Bus Company"; // Cannot modify Manufacturer because it is a read-only auto-property
Console.WriteLine(bus.Manufacturer);

class Bus
{
    private string _name = "Default Bus"; 

    public string Name
    {
        get { return _name; }
        set { _name = string.IsNullOrWhiteSpace(value) ? _name : value; }
    }

    // Auto-property with get and set accessors 
    public string Operator { get; set; } = string.Empty;

    // Auto-property with get and init accessors
    public int Capacity { get; init; }

    // Read-only auto-property being initialized with a value
    public string Manufacturer { get; } = "Global Bus Company";
}