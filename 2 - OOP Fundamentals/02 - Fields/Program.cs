// Instantiate frist Car object and initialize using object initializer
Car car1 = new() 
{
    make = "Toyota",
    model = "Corolla"
    // vin = "abc123" // Cannot access vin, it is a private field
};
Console.WriteLine($"Car1 make: {car1.make}, model: {car1.model}");

// Instantiate second Car object and initialize using object initializer
Car car2 = new()
{
    make = "Honda",
    model = "Civic"
    // vin = "abc456"; // Cannot access vin, it is a private field
};
Console.WriteLine($"Car2 make: {car2.make}, model: {car2.model}");

public class Car
{
    public string make = string.Empty;

    public string model = string.Empty;

    /*
    * Students please ignore this "pragma" line here and at the bottom of the file
    * This is for suppressing warnings as it was intended to declare a field but never use it
    * in order to showcase how to write private fields in a class.
    */
    #pragma warning disable CS0414
    private string _vin = string.Empty; // Cannot access or modify a private field anywhere else except the class itself
    #pragma warning restore CS0414
}