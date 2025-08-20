Product product1 = new() { Title = "Laptop", Price = 1050.55m, Category = "Technology" };
Console.WriteLine($"Product 1: {product1.Title}, ${product1.Price}, {product1.Category}");

Product product2 = new() { Title = "Battery Pack", Price = 15.99m };
Console.WriteLine($"Product 2: {product2.Title}, ${product2.Price}, {product2.Category}");

class Product
{
    public required string Title { get; set; }

    public required decimal Price { get; init; }

    public string Category { get; set; } = "Default";
}