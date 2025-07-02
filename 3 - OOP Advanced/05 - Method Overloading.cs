CourseRepository courseRepository = new(); 
RegistrationSystem registrationSystem = new(courseRepository);

Student newStudent = new("John", "Doe"); 

var registration1 = registrationSystem.Register(newStudent, 1);
var registration2 = registrationSystem.Register(newStudent, "ABC123");
var registration3 = registrationSystem.Register(newStudent, 1, "I don't have all prerequisites, but comfortable with the curriculum");
var registration4 = registrationSystem.Register(newStudent, "CompSci101", 10);

Console.WriteLine(registration1);
Console.WriteLine(registration2);
Console.WriteLine(registration3);
Console.WriteLine(registration4);

class RegistrationSystem(CourseRepository courseRepository)
{
    private readonly CourseRepository _courseRepository = courseRepository;

    public string Register(Student student, string enrollmentToken)
    {
        var courseId = _courseRepository.FindCourseId(enrollmentToken);
        if (courseId == -1)
        {
            // In real-world you would throw an exception, return an error result and/or log
        }
        return $"{Register(student, courseId)} | Enrollment Token ({enrollmentToken})";
    }

    public string Register(Student student, int courseId, string note) => $"{Register(student, courseId)} | Note ({note})";

    public string Register(Student student, string courseName, int instructorId)
    {
        var courseId = _courseRepository.FindCourseId(courseName, instructorId);
        if (courseId == -1)
        {
            // In real-world you would throw an exception, return an error result and/or log
        }
        return $"{Register(student, courseId)} | Course Name ({courseName}) | InstructorId ({instructorId})";
    }

    public string Register(Student student, int courseId) => $"Registering {student.FirstName} {student.LastName} for CourseId ({courseId})";
}

class Student(string firstName, string lastName)
{
    public string FirstName { get; init; } = firstName;

    public string LastName { get; init; } = lastName;
}

class CourseRepository
{
    public int FindCourseId(string enrollmentToken) => enrollmentToken.Equals("ABC123") ? 1 : -1;

    public int FindCourseId(string courseName, int instructorId) => courseName.Equals("CompSci101") && instructorId == 10 ? 1 : -1;
}