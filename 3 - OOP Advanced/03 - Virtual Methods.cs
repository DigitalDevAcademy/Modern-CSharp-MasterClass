BaseClass someClass = new DerivedClass(1, 2);

class BaseClass
{
    protected int SomeBaseValue { get; set; }
     
    public BaseClass(int baseValue)
    {
        SomeBaseValue = baseValue;
    }
    
    protected int BaseMethod(int a, int b) => a + b; 
}

class DerivedClass : BaseClass
{
    public int SomeValue { get; set; }
  
    public DerivedClass(int value, int baseValue) : base(baseValue)
    {
        SomeValue = value + SomeBaseValue + BaseMethod(1, 2);
    }
}

