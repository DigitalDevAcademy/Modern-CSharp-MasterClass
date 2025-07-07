SchoolMember schoolMember1 = new Student("John", "Doe", 3.5m);
SchoolMember schoolMember2 = new Teacher("Sarah", "Doe", "Computer Science");

DisplaySchoolMemberInfo(schoolMember1);
DisplaySchoolMemberInfo(schoolMember2);

void DisplaySchoolMemberInfo(SchoolMember schoolMember)
{

    if (schoolMember is Student s)
    {
        // Student s = (Student)schoolMember;
        Console.WriteLine($"{s.FirstName} {s.LastName} has a GPA of {s.GPA}");
        s.RequestExtension();
    }
    else if (schoolMember is Teacher t)
    {
        // Teacher t = (Teacher)schoolMember;
        Console.WriteLine($"{t.FirstName} {t.LastName} works in the {t.Department} department");
        t.ApproveExtension();
    }
}

abstract class SchoolMember
{
    public string FirstName { get; init; }

    public string LastName { get; init; }

    public SchoolMember(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Student : SchoolMember
{
    public decimal GPA { get; init; }

    public Student(string firstName, string lastName, decimal GPA) : base(firstName, lastName)
    {
        this.GPA = GPA;
    }

    public void RequestExtension() => Console.WriteLine("Requesting extension");
}

class Teacher : SchoolMember
{
    public string Department { get; init; }

    public Teacher(string firstName, string lastName, string department) : base(firstName, lastName)
    {
        Department = department;
    }

    public void ApproveExtension() => Console.WriteLine("Extension approved");
}