// Instantiate frist Car object
Car car1 = new() 
{
    make = "Toyota",
    model = "Corolla"
    // vin = "abc123" // Cannot access vin, it is a private field
};
Console.WriteLine($"Car1 make is {car1.make} and model is {car1.model}.");

// Instantiate second Car object
Car car2 = new()
{
    make = "Honda",
    model = "Civic"
    // vin = "abc456"; // Cannot access vin, it is a private field
};
Console.WriteLine($"Car2 make is {car2.make} and model is {car2.model}.");

// Instantiate third Car object
Car car3 = new()
{
    make = "Ford",
    model = "Mustang"
    // vin = "abc789"; // Cannot access vin, it is a private field
};
Console.WriteLine($"Car3 make is {car3.make} and model is {car3.model}.");

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
    private string vin = string.Empty; // Cannot access or modify a private field anywhere else except the class itself
    #pragma warning restore CS0414
}