User user1 = new(1);
ChangeUserWithRef(ref user1);
void ChangeUserWithRef(ref User user)
{
    user.Id = 2;
}
Console.WriteLine($"User1 Id is {user1.Id}");

//var User user2; <-- We no longer have to declare a separate variable and can do it inline since C# 7.0
CreateUserWithOut(out User user2);
void CreateUserWithOut(out User user)
{
    user = new(2);
}
Console.WriteLine($"User2 Id is {user2.Id}");

User user3 = new(1);
AccessUserWithIn(in user3); // in keyword introduced in C# 7.2
void AccessUserWithIn(in User user)
{
    //user = new(1); <-- Results in compile-time error since 'user' is read-only
    //user.Id = 2;   <-- Results in compile-time error since 'user' is read-only
    Console.WriteLine($"User3 Id is {user.Id}"); // <-- We can read user but cannot modify it
}

struct User(int id)
{
    public int Id { get; set; } = id;
}
