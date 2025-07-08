SchoolMember schoolMember1 = new Student("John", "Doe", 3.5m);
SchoolMember schoolMember2 = new Teacher("Sarah", "Doe", "Computer Science");

DisplaySchoolMemberInfo(schoolMember1);
DisplaySchoolMemberInfo(schoolMember2);

void DisplaySchoolMemberInfo(SchoolMember schoolMember)
{
    Console.WriteLine(schoolMember.GetInfo());
}

class SchoolMember
{
    public string FirstName { get; init; }

    public string LastName { get; init; }

    public SchoolMember(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public virtual string GetInfo() => $"{FirstName} {LastName}";
}

class Student : SchoolMember
{
    public decimal GPA { get; init; }

    public Student(string firstName, string lastName, decimal GPA) : base(firstName, lastName)
    {
        this.GPA = GPA;
    }

    public override string GetInfo() => $"{base.GetInfo()} {GPA}";
}

class Teacher : SchoolMember
{
    public string Department { get; init; }

    public Teacher(string firstName, string lastName, string department) : base(firstName, lastName)
    {
        Department = department;
    }

    public override string GetInfo() => $"{base.GetInfo()} {Department}";
}