SchoolMember schoolMember1 = new Student("John", "Doe", 3.5m);
SchoolMember schoolMember2 = new Teacher("Sarah", "Doe", "Computer Science");
// Cannot instantiate an abstract class
// SchoolMember schoolMember = new SchoolMember("SomeFirstName", "SomeLastName");

DisplaySchoolMemberParticipation(schoolMember1);
DisplaySchoolMemberParticipation(schoolMember2);

void DisplaySchoolMemberParticipation(SchoolMember schoolMember)
{
    Console.WriteLine($"{schoolMember.FirstName} {schoolMember.LastName} participation:");
    schoolMember.Participate();
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

    // Example of abstraction - we just know that a school member (teacher or student) participates but don't know how
    public abstract void Participate();
}

class Student : SchoolMember
{
    public decimal GPA { get; init; }

    public Student(string firstName, string lastName, decimal GPA) : base(firstName, lastName)
    {
        this.GPA = GPA;
    }

    public override void Participate()
    {
        /* 
         * Example of encapsulation using access modifiers - here we define how Student participates 
         * but we use private access modifiers in order to hide implementation details 
         */
        TakeNotes();
        CompleteHomework();
        ApplyFeedback();
    }

    void TakeNotes() => Console.WriteLine("Taking notes.");
    void CompleteHomework() => Console.WriteLine("Completing homework.");
    void ApplyFeedback() => Console.WriteLine("Applying feedback.");
}

class Teacher : SchoolMember
{
    public string Department { get; init; }

    public Teacher(string firstName, string lastName, string department) : base(firstName, lastName)
    {
        Department = department;
    }
    
    public override void Participate()
    {
        /* 
         * Example of encapsulation using access modifiers - here we define how Teacher participates 
         * but we use private access modifiers in order to hide implementation details
         */
        TeachMaterial();
        AssignHomework();
        ProvideFeedback();
    }

    void TeachMaterial() => Console.WriteLine("Teaching material.");
    void AssignHomework() => Console.WriteLine("Assigning homework.");
    void ProvideFeedback() => Console.WriteLine("Providing feedback.");
}