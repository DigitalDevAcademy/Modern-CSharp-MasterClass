// Initializing a struct and a class with only one field
UserStruct userStruct = new() { Id = 1 };
UserClass userClass = new() { Id = 1 };

// Printing both values before changing them
Console.WriteLine($"UserStruct.Id: {userStruct.Id} | UserClass.Id: {userClass.Id}");

ChangeUserId(userStruct, userClass);

// Printing both values after changing them
Console.WriteLine($"UserStruct.Id: {userStruct.Id} | UserClass.Id: {userClass.Id}");

// Modify both values to see the difference between stack vs heap
void ChangeUserId(UserStruct userStruct, UserClass userClass)
{
    userStruct.Id = 2;
    userClass.Id = 2;
}

// Struct is a value type, so it is stored on the stack
struct UserStruct
{
    public int Id { get; set; }
}

// Class is a reference type, so it is stored on the heap
class UserClass
{
    public int Id { get; set; }
}