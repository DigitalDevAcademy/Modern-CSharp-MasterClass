// Upcasting
SchoolMember schoolMember1 = new Student("John", "Doe", 3.5m);
SchoolMember schoolMember2 = new Teacher("Mark", "Doe", "Computer Science");

// You cannot access derived class members from the base class
// Console.WriteLine(schoolMember1.GPA); 
// Console.WriteLine(schoolMember2.Department);

// Downcasting
Student student = (Student)schoolMember1;
Teacher teacher = (Teacher)schoolMember2;
// Teacher teacher = (Teacher)schoolMember1; // Will fail - Unable to cast object of type 'Student' to type 'Teacher'

// You can access base class members from the derived class
Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
Console.WriteLine($"Teacher: {teacher.FirstName} {teacher.LastName}");

class SchoolMember
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
}

class Teacher(string firstName, string lastName, string department) : SchoolMember(firstName, lastName)
{
    public string Department { get; init; } = department;
}