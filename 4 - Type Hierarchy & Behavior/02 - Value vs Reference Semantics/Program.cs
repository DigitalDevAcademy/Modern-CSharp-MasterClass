// Initializing a struct and a class with only one field
UserStruct userStruct = new(30);
UserClass userClass = new(30);

UserStruct anotherUserStruct = userStruct; // Creates a copy
anotherUserStruct.Age++;

Console.WriteLine(anotherUserStruct.Age);
Console.WriteLine(userStruct.Age);

UserClass anotherUserClass = userClass; // Creates a reference
anotherUserClass.Age++;

Console.WriteLine(anotherUserClass.Age);
Console.WriteLine(userClass.Age);

// Struct is a value type
struct UserStruct(int age)
{
    public int Age { get; set; } = age;
}

// Class is a reference type
class UserClass(int age)
{
    public int Age { get; set; } = age;
}