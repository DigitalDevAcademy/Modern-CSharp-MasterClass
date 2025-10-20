IPayable worker1 = new Teacher();
IPayable worker2 = new Photographer();
IPayable worker3 = new Electrician();

ProcessPayments(worker1);
ProcessPayments(worker2);
ProcessPayments(worker3);

void ProcessPayments(IPayable worker) => worker.RequestPayment();

interface IPayable
{
    void RequestPayment();
}

abstract class SchoolMember
{
    public abstract void Participate();
}

class Student : SchoolMember
{
    public override void Participate() => Console.WriteLine("Completing homework and taking notes");
}

class Teacher : SchoolMember, IPayable
{
    public override void Participate() => Console.WriteLine("Assigning homework and providing notes");

    public void RequestPayment() => Console.WriteLine("Teacher has received payment");

}

abstract class ExternalServiceProvider
{
    public abstract void ProvideService();
}

class Photographer : ExternalServiceProvider, IPayable
{
    public override void ProvideService() => Console.WriteLine("Taking photos");

    public void RequestPayment() => Console.WriteLine("Photographer has received payment");
}

class Electrician : ExternalServiceProvider, IPayable
{
    public override void ProvideService() => Console.WriteLine("Fixing electricity");

    public void RequestPayment() => Console.WriteLine("Electrician has received payment");
}