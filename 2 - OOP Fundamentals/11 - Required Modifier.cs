Product productOne = new() { Name = "Laptop", Price = 1050.55m, Category = "Technology" };
Console.WriteLine(productOne.GetInfo());

Product productTwo = new() { Name = "Battery Pack", Price = 15.99m };
Console.WriteLine(productTwo.GetInfo());

public class Product
{
    // Object initializer is required to set this property
    public required string Name { get; init; }

    // Object initializer is required to set this property
    public required decimal Price { get; init; }

    public string Category { get; set; } = "Default";

    public string GetInfo() => $"Product Info: {Name} {Price} {Category}";
}