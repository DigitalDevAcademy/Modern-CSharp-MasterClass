Box box = new() { Capacity = 20 };
Console.WriteLine(box.IsFull());
box.AddItems(10);
Console.WriteLine(box.IsFull());
box.AddItems(10);
Console.WriteLine(box.IsFull());
box.AddItems(1);

class Box
{
    public int Capacity { get; init; } = 10;

    public int ItemCount { get; set; }

    // Void method with one parameter
    public void AddItems(int newItems)
    {
        if (ItemCount + newItems > Capacity) 
        {
            Console.WriteLine("Over capacity.");
            // Return statement only used to exit the method back to the caller
            return;
        }

        ItemCount += newItems;
        Console.WriteLine($"Item added. Total number of items are {ItemCount}.");
    }

    // Parameterless method returning a value of type bool
    public bool IsFull()
    {
        return ItemCount >= Capacity;
    }
}
