SchoolMember schoolMember1 = new Student();
SchoolMember schoolMember2 = new Teacher();
// Cannot instantiate an abstract class
// SchoolMember schoolMember = new();

DisplaySchoolMemberParticipation(schoolMember1);
DisplaySchoolMemberParticipation(schoolMember2);

void DisplaySchoolMemberParticipation(SchoolMember schoolMember)
{
    Console.WriteLine(schoolMember.ToString());
    schoolMember.Participate();
}

abstract class SchoolMember
{
    // Example of abstraction - we just know that a school member (teacher or student) participates but don't know how
    public abstract void Participate();
}

class Student : SchoolMember
{
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

    void TakeNotes() => Console.WriteLine("Taking notes");
    void CompleteHomework() => Console.WriteLine("Completing homework");
    void ApplyFeedback() => Console.WriteLine("Applying feedback");
}

class Teacher : SchoolMember
{
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

    void TeachMaterial() => Console.WriteLine("Teaching material");
    void AssignHomework() => Console.WriteLine("Assigning homework");
    void ProvideFeedback() => Console.WriteLine("Providing feedback");
}