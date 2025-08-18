Product productOne = new() { Description = "Laptop", Price = 1050.55m, Category = "Technology" };
Console.WriteLine(productOne.GetInfo());

Product productTwo = new() { Description = "Battery Pack", Price = 15.99m };
Console.WriteLine(productTwo.GetInfo());

class Product
{
    // Object initializer is required to set this property
    public required string Description { get; init; }

    // Object initializer is required to set this property
    public required decimal Price { get; init; }

    public string Category { get; set; } = "Default";

    public string GetInfo() => $"Product Info: {Description} {Price} {Category}";
}