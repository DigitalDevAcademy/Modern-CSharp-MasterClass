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
// bus.Manufacturer = "Another Bus Company"; // Cannot modify Manufacturer because it is a read-only property
Console.WriteLine(bus.Manufacturer);

public class Bus
{
    // Setting a default for the backing field
    private string _name = "Default Bus"; 

    /* Property using the backing field.
     * We could have also separated get or set accessors into separate properties making them read-only/write-only respectively
     * We could have also used init instead of set making this property immutable if needed
     */
    public string Name
    {
        get { return _name; }
        set { _name = string.IsNullOrWhiteSpace(value) ? "Default Bus" : value; }
    }

    // Auto-property with get and set accessors    
    public string Operator { get; set; } = string.Empty;

    // Auto-property with get and init accessors
    public int Capacity { get; init; }

    // Read-only auto-property being initialized with a value
    public string Manufacturer { get; } = "Global Bus Company";
}