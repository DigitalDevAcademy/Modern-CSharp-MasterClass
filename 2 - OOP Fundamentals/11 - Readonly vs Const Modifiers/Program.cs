SomeDependency dependency = new();  
SomeClass someClass = new(dependency);
 
someClass.SomeMethod();
someClass.PrintLocalConstant();

Console.WriteLine($"Static ReadOnly Field Value: {SomeClass.SomeUniqueId}");
Console.WriteLine($"Const Field Value: {SomeClass.SomeConstant}");

class SomeClass
{
    public const string SomeConstant = "Constant value";

    public static readonly Guid SomeUniqueId = Guid.NewGuid();

    private readonly SomeDependency _dependency;

    public SomeClass(SomeDependency dependency) => _dependency = dependency;

    public void SomeMethod() => _dependency.DoWork();

    public void PrintLocalConstant()
    {
        const string SomeValue = "SomeText";
        Console.WriteLine($"Local Constant Value: {SomeValue}");
    }    
}

class SomeDependency
{
    public void DoWork() => Console.WriteLine("Work completed");
}
