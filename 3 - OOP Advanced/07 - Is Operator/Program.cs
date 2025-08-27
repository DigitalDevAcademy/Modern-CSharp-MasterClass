SchoolMember schoolMember1 = new Student("Mateo", "Rossi", 3.5m);
SchoolMember schoolMember2 = new Teacher("Marcus", "Fischer", "Computer Science");

ProcessExtension(schoolMember1);
ProcessExtension(schoolMember2);

void ProcessExtension(SchoolMember schoolMember)
{
    if (schoolMember is Student s)
    {
        Console.WriteLine($"{s.FirstName} {s.LastName} has a GPA of {s.GPA}");
        s.RequestExtension();
    }
    else if (schoolMember is Teacher t)
    {
        Console.WriteLine($"{t.FirstName} {t.LastName} works in the {t.Department} department");
        t.ApproveExtension();
    }
}

abstract class SchoolMember
{
    public string FirstName { get; init; }

    public string LastName { get; init; }

    protected SchoolMember(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Student(string firstName, string lastName, decimal gpa) : SchoolMember(firstName, lastName)
{
    public decimal GPA { get; init; } = gpa;

    public void RequestExtension() => Console.WriteLine("Requesting extension");
}

class Teacher(string firstName, string lastName, string department) : SchoolMember(firstName, lastName)
{
    public string Department { get; init; } = department;

    public void ApproveExtension() => Console.WriteLine("Extension approved");
}