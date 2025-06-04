SomeDependency dependency = new();  
SomeClass someClass = new(dependency);
 
someClass.SomeMethod();
someClass.PrintLocalConstant();
// someClass.dependency = new SomeDependency(); // A readonly field cannot be assigned to after initialization

Console.WriteLine($"Static Readonly Field Value: {SomeClass.someUniqueId}");
Console.WriteLine($"Const Field Value: {SomeClass.someConstant}");

public class SomeClass
{
    // Declaring a readonly field - can hold any type and be assigned directly or inside constructor
     public readonly SomeDependency dependency;

     /* 
      * Declaring static readonly field - can hold any type and be evaluated during runtime and be assigned 
      * directly or inside static constructor
      */ 
     public static readonly Guid someUniqueId = Guid.NewGuid();

     // Declaring a const field - can only hold primitives and string and only be assigned directly
     public const string someConstant = "Constant Value";

    // Perfomring IoC (Inversion of Control) using constructor injection
     public SomeClass(SomeDependency dependency)
     {
          this.dependency = dependency;
     }
     
     // SomeMethod using method from a dependency
     public void SomeMethod() => dependency.DoWork();
     
     public void PrintLocalConstant()
     {
        // Declaring a local constant, const within a method
        const string someValue = "SomeText";
        Console.WriteLine($"Local Constant Value: {someValue}");
     }    
}

public class SomeDependency
{
    public void DoWork() => Console.WriteLine("Work completed.");
}
