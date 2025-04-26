Car myCar = new();
myCar.Drive();
myCar.Drive();
myCar.Drive();
myCar.Drive();
myCar.Drive();
myCar.Refuel(-100);
myCar.Refuel(101);
myCar.Drive();
myCar.Drive();
myCar.Drive();
myCar.Drive();
myCar.Drive();
myCar.Refuel(100);
myCar.Drive();

public class Car
{
    public int CurrentFuel { get; set; } = 100;

    // Void method does not return anything, also parameterless meaning it does not take in any parameters
    public void Drive()
    {
        if (CurrentFuel > 0)
        {
            Console.WriteLine("Car is moving.");
            CurrentFuel -= 25;
        }
        else
        {
            Console.WriteLine("Car doesn't have enough fuel. Please refuel!");
        }
    }

    // Method returning value of type bool and taking in one parameter of type int
    public bool Refuel(int newFuel)
    {
        if (newFuel < 0)
        {
            // In real-life this would be an exception, but for now we are printing a message
            Console.WriteLine("No fuel was added.");
            return false;
        }
        
        if (CurrentFuel + newFuel > 100)
        {
            // If the sum of incoming fuel and current fuel go above 100 we only keep 100 and discard the rest and print a message
            CurrentFuel = 100;
            Console.WriteLine("The fuel tank is over capacity.");
            return true;
        }
        
        // If we are within capacity then keep adding incoming fuel to our current fuel level
        CurrentFuel += newFuel;
        return true;
    }
}