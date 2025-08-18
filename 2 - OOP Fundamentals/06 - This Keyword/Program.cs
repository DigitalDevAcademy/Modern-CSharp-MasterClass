Smartphone phone1 = new();
Console.WriteLine($"Phone 1: {phone1.Model}, {phone1.Color}, {phone1.StorageCapacity}GB");

Smartphone phone2 = new("Pro");
Console.WriteLine($"Phone 2: {phone2.Model}, {phone2.Color}, {phone2.StorageCapacity}GB");

Smartphone phone3 = new("Pro", "Silver");
Console.WriteLine($"Phone 3: {phone3.Model}, {phone3.Color}, {phone3.StorageCapacity}GB");

Smartphone phone4 = new("Pro", "Silver", 512);
Console.WriteLine($"Phone 4: {phone4.Model}, {phone4.Color}, {phone4.StorageCapacity}GB");

class Smartphone
{
    public string Model { get; init; }

    public string Color { get; init; }

    public int StorageCapacity { get; init; }

    public Smartphone() : this("Standard")
    {
    }

    public Smartphone(string model) : this(model, "White")
    {
    }

    public Smartphone(string model, string color) : this(model, color, 64)
    {
    }

    public Smartphone(string model, string color, int storageCapacity)
    {
        Model = model;
        Color = color;
        StorageCapacity = storageCapacity;
    }
}