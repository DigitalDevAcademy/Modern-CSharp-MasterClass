IPayable payableWorker1 = new Teacher("Sarah", "Doe", "Computer Science");
IPayable payableWorker2 = new Photographer("Some Example Photography LLC");
IPayable payableWorker3 = new Electrician("Some Example Electrician LLC");

ProcessPayments(payableWorker1);
ProcessPayments(payableWorker2);
ProcessPayments(payableWorker3);

void ProcessPayments(IPayable payableSchoolMember) => payableSchoolMember.RequestPayment();

public interface IPayable
{
    void RequestPayment();
}

abstract class SchoolMember(string firstName, string lastName)
{
    public string FirstName { get; init; } = firstName;

    public string LastName { get; init; } = lastName;

    public abstract void Participate();
}

class Student(string firstName, string lastName, decimal gpa) : SchoolMember(firstName, lastName)
{
    public decimal GPA { get; init; } = gpa;

    public override void Participate() => Console.WriteLine("Completing homework and taking notes");
}

class Teacher(string firstName, string lastName, string department) : SchoolMember(firstName, lastName), IPayable
{
    public string Department { get; init; } = department;

    public void RequestPayment() => Console.WriteLine("Teacher has received payment");

    public override void Participate() => Console.WriteLine("Assigning homework and providing notes");
}

abstract class ExternalServiceProvider(string company)
{
    public abstract void ProvideService();

    public string Company { get; init; } = company;
}

class Photographer(string company) : ExternalServiceProvider(company), IPayable
{
    public override void ProvideService() => Console.WriteLine("Taking photoes");

    public void RequestPayment() => Console.WriteLine("Photographer has received payment");
}

class Electrician(string company) : ExternalServiceProvider(company), IPayable
{
    public override void ProvideService() => Console.WriteLine("Fixing electricity");

    public void RequestPayment() => Console.WriteLine("Electrician has received payment");
}