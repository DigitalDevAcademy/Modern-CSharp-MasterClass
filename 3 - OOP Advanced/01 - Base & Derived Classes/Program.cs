Student student = new("Mateo", "Rossi", 3.5m);
Teacher teacher = new("Marcus", "Fischer", "Computer Science");

Console.WriteLine(student.GPA);
Console.WriteLine(teacher.Department);

Console.WriteLine($"Before: {student.FirstName} {student.LastName}");
student.SetInfo("Rafael", "Caruso");
Console.WriteLine($"After: {student.FirstName} {student.LastName}");

student.SetGPA(4);
Console.WriteLine(student.GPA);

teacher.SetDepartment("Biology");
Console.WriteLine(teacher.Department);

class SchoolMember
{
    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    protected SchoolMember(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void SetInfo(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Student(string firstName, string lastName, decimal gpa) : SchoolMember(firstName, lastName)
{
    public decimal GPA { get; private set; } = gpa;

    public void SetGPA(decimal gpa) => GPA = gpa;
}

class Teacher(string firstName, string lastName, string department) : SchoolMember(firstName, lastName)
{
    public string Department { get; private set; } = department;

    public void SetDepartment(string department) => Department = department;
}