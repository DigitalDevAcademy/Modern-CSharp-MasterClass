User user1 = new() { FirstName = "John", LastName = "Doe" };
User user2 = new() { FirstName = "Mark", LastName = "Doe",  Age = 30};

PrintAgeInfo(user1);
PrintAgeInfo(user2);

void PrintAgeInfo(User user)
{
    if (user.Age is int age)
    {
        Console.WriteLine($"{user.FirstName} {user.LastName} is {age} years old.");
    }
    else
    {
        Console.WriteLine($"{user.FirstName} {user.LastName} did not specify their age.");
    }
}

class User
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public int? Age { get; set; }
}