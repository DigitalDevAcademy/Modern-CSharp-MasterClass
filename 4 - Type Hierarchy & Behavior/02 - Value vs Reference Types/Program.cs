// Initializing a struct and a class with only one field
// Value vs reference semantics - example 1
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

// Value vs reference semantics - example 2
// UserStruct userStruct = new(30);
// UserClass userClass = new(30);

// // Printing both values before changing them
// Console.WriteLine(userStruct.Age);
// Console.WriteLine(userClass.Age);

// ChangeUserId(userStruct, userClass);

// // Printing both values after changing them
// Console.WriteLine(userStruct.Age);
// Console.WriteLine(userClass.Age);

// // Modify both values to see the difference between stack vs heap
// void ChangeUserId(UserStruct userStruct, UserClass userClass)
// {
//     userStruct.Age = 35;
//     userClass.Age = 35;
// }

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