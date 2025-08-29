// Example 1
UserStruct structObject = new(30);
UserClass classObject = new(30);

UserStruct anotherStructObject = structObject; // Creates a copy
anotherStructObject.Age++;

Console.WriteLine(anotherStructObject.Age);
Console.WriteLine(structObject.Age);

UserClass anotherClassObject = classObject; // Creates a reference
anotherClassObject.Age++;

Console.WriteLine(anotherClassObject.Age);
Console.WriteLine(classObject.Age);

// Example 2
// UserStruct structObject = new(30);
// UserClass classObject = new(30);

// Console.WriteLine(structObject.Age);
// Console.WriteLine(classObject.Age);

// ChangeUserAge(structObject, classObject);

// Console.WriteLine(structObject.Age);
// Console.WriteLine(classObject.Age);

// void ChangeUserAge(UserStruct structObject, UserClass classObject)
// {
//     structObject.Age = 35;
//     classObject.Age = 35;
// }

struct UserStruct(int age)
{
    public int Age { get; set; } = age;
}

class UserClass(int age)
{
    public int Age { get; set; } = age;
}