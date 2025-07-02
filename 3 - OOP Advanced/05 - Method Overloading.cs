Student student = new Student("John", "Doe");

var registration1 = student.Register(1);
var registration2 = student.Register("ABC123");
var registration3 = student.Register(1, "I don't have all prerequisites, but comfortable with the curriculum");
var registration4 = student.Register("CompSci101", 10);

Console.WriteLine(registration1);
Console.WriteLine(registration2);
Console.WriteLine(registration3);
Console.WriteLine(registration4);

class Student(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;

    public string LastName { get; set; } = lastName;

    public string Register(string enrollmentToken)
    {
        var courseId = FindCourseId(enrollmentToken);
        if (courseId == -1)
        {
            // In real-world you would throw an exception, return an error result and/or log
        }
        return $"{Register(courseId)} | Enrollment Token ({enrollmentToken})";
    }

    public string Register(int courseId, string note) => $"{Register(courseId)} | Note ({note})";

    public string Register(string courseName, int instructorId)
    {
        var courseId = FindCourseId(courseName, instructorId);
        if (courseId == -1)
        {
            // In real-world you would throw an exception, return an error result and/or log
        }
        return $"{Register(courseId)} | Course Name ({courseName}) | InstructorId ({instructorId})";
    }

    public string Register(int courseId) => $"Registering {FirstName} {LastName} for CourseId ({courseId})";

    private int FindCourseId(string enrollmentToken) => enrollmentToken.Equals("ABC123") ? 1 : -1;

    private int FindCourseId(string courseName, int instructorId) => courseName.Equals("CompSci101") && instructorId == 10 ? 1 : -1;
}