SchoolMember schoolMember1 = new Student("John", "Doe", 3.5m);
SchoolMember schoolMember2 = new Teacher("Sarah", "Doe", "Computer Science");

// You cannot access derived class members from the base class
// Console.WriteLine(schoolMember1.GPA); 
// Console.WriteLine(schoolMember2.Department);

Student student = (Student)schoolMember1;
Teacher teacher = (Teacher)schoolMember2;

Console.WriteLine(student.GPA);
Console.WriteLine(teacher.Department);

Console.WriteLine($"Before: {teacher.FirstName} {teacher.LastName}");
teacher.UpdateInfo("Sophia", "Doe"); // We can access base members from a derived class
// student.UpdateInfo("Mark", "Doe");
Console.WriteLine($"After: {teacher.FirstName} {teacher.LastName}");

student.UpdateGPA(-1);
student.UpdateGPA(5);
Console.WriteLine(student.GPA);
student.UpdateGPA(4);
Console.WriteLine(student.GPA);

teacher.UpdateDepartment(string.Empty);
Console.WriteLine(teacher.Department);
teacher.UpdateDepartment("Biology");
Console.WriteLine(teacher.Department);

class SchoolMember
{
    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public SchoolMember(string make, string model)
    {
        FirstName = make;
        LastName = model;
    }

    public void UpdateInfo(string firstName, string lastName)
    {
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