SchoolMember schoolMember1 = new Student("Mateo", "Rossi", 3.5m);
SchoolMember schoolMember2 = new Teacher("Marcus", "Fischer", "Computer Science");

DisplaySchoolMemberInfo(schoolMember1);
DisplaySchoolMemberInfo(schoolMember2);

void DisplaySchoolMemberInfo(SchoolMember schoolMember)
{
    Console.WriteLine(schoolMember.GetInfo());
}

class SchoolMember
{
    private string _firstName;

    private string _lastName;

    protected SchoolMember(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public virtual string GetInfo() => $"{_firstName} {_lastName}";
}


class Student(string firstName, string lastName, decimal gpa) : SchoolMember(firstName, lastName)
{
    private decimal _gpa = gpa;

    public override string GetInfo() => $"{base.GetInfo()} {_gpa}";
}

class Teacher(string firstName, string lastName, string department) : SchoolMember(firstName, lastName)
{
    private string _department = department;

    public override string GetInfo() => $"{base.GetInfo()} {_department}";
}