Student student = new Student("John", "Doe", 3.5m);
Teacher teacher = new Teacher("Sarah", "Doe", "Computer Science");

Console.WriteLine(student.GPA);
Console.WriteLine(teacher.Department);

Console.WriteLine($"Before: {teacher.FirstName} {teacher.LastName}");
teacher.UpdateInfo("Sophia", "Doe");
// student.UpdateInfo("Mark", "Doe");
Console.WriteLine($"After: {teacher.FirstName} {teacher.LastName}");

student.UpdateGPA(4);
Console.WriteLine(student.GPA);

teacher.UpdateDepartment("Biology");
Console.WriteLine(teacher.Department);

class SchoolMember
{
    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public SchoolMember(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void UpdateInfo(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            // In real-life you could return an error result or throw an exception and/or log it as well
            Console.WriteLine("Invlaid firstname and/or lastname!");
            return;
        }

        FirstName = firstName;
        LastName = lastName;
    }
}

class Student : SchoolMember
{
    public decimal GPA { get; private set; }

    public Student(string firstName, string lastName, decimal GPA) : base(firstName, lastName)
    {
        this.GPA = GPA;
    }

    public void UpdateGPA(decimal gpa)
    {
        if (gpa < 0 || gpa > 4)
        {
            // In real-life you could return an error result or throw an exception and/or log it as well
            Console.WriteLine("Invlaid GPA!");
            return;
        }

        GPA = gpa;
    }
}

class Teacher : SchoolMember
{
    public string Department { get; private set; }

    public Teacher(string firstName, string lastName, string department) : base(firstName, lastName)
    {
        Department = department;
    }

    public void UpdateDepartment(string department)
    {
        if (string.IsNullOrWhiteSpace(department))
        {
            // In real-life you could return an error result or throw an exception and/or log it as well
            Console.WriteLine("Invlaid department!");
            return;
        }

        Department = department;
    }
}