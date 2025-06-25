// Upcasting
SchoolMember schoolMember1 = new Student("John", "Doe", 3.5m);
SchoolMember schoolMember2 = new Teacher("Sarah", "Doe", "Computer Science");

// You cannot access derived class members from the base class
// Console.WriteLine(schoolMember1.GPA); 
// Console.WriteLine(schoolMember2.Department);

// Downcasting
Student student = (Student)schoolMember1;
Teacher teacher = (Teacher)schoolMember2;

// You can access base class members from the derived class
Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
Console.WriteLine($"Teacher: {teacher.FirstName} {teacher.LastName}");

class SchoolMember
{
    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public SchoolMember(string make, string model)
    {
        FirstName = make;
        LastName = model;
    }
}

class Student : SchoolMember
{
    public decimal GPA { get; private set; }

    public Student(string firstName, string lastName, decimal GPA) : base(firstName, lastName)
    {
        this.GPA = GPA;
    }
}

class Teacher : SchoolMember
{
    public string Department { get; private set; }

    public Teacher(string firstName, string lastName, string department) : base(firstName, lastName)
    {
        Department = department;
    }
}