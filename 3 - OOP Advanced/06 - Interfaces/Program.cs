IPayable payableWorker1 = new Teacher();
IPayable payableWorker2 = new Photographer();
IPayable payableWorker3 = new Electrician();

ProcessPayments(payableWorker1);
ProcessPayments(payableWorker2);
ProcessPayments(payableWorker3);

void ProcessPayments(IPayable payableSchoolMember) => payableSchoolMember.RequestPayment();

public interface IPayable
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
    public void RequestPayment() => Console.WriteLine("Teacher has received payment");

    public override void Participate() => Console.WriteLine("Assigning homework and providing notes");
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