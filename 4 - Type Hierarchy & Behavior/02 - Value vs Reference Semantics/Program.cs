// Initializing a struct and a class with only one field
// Value vs reference semantics - example 1
UserStruct userStruct = new(1);
UserClass userClass = new(1);

UserStruct anotherUserStruct = userStruct; // Creates a copy
anotherUserStruct.Id++;

Console.WriteLine(anotherUserStruct.Id);
Console.WriteLine(userStruct.Id);

UserClass anotherUserClass = userClass; // Creates a reference
anotherUserClass.Id++;

Console.WriteLine(anotherUserClass.Id);
Console.WriteLine(userClass.Id);

// Value vs reference semantics - example 2
// UserStruct userStruct = new(1);
// UserClass userClass = new(1);

// // Printing both values before changing them
// Console.WriteLine(userStruct.Id);
// Console.WriteLine(userClass.Id);

// ChangeUserId(userStruct, userClass);

// // Printing both values after changing them
// Console.WriteLine(userStruct.Id);
// Console.WriteLine(userClass.Id);

// // Modify both values to see the difference between stack vs heap
// void ChangeUserId(UserStruct userStruct, UserClass userClass)
// {
//     userStruct.Id = 2;
//     userClass.Id = 2;
// }

// Struct is a value type
struct UserStruct(int id)
{
    public int Id { get; set; } = id;
}

// Class is a reference type
class UserClass(int id)
{
    public int Id { get; set; } = id;
}