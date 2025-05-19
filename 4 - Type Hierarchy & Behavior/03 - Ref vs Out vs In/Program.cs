using System.Security.Permissions;

int firstNumber = 1;
ChangeUsingRef(ref firstNumber);
void ChangeUsingRef(ref int number) => number = 2;
Console.WriteLine(firstNumber);

// Starting with C# 7.0 you can declare out variables inline
ChangeUsingOut(out int secondNumber);
void ChangeUsingOut(out int number) => number = 2;
Console.WriteLine(secondNumber);

int thirdNumber = 1;
// Starting with C# 7.2 you can declare method params as read-only, recommended for value-types only
AccessUsingIn(in thirdNumber);
void AccessUsingIn(in int number) => Console.WriteLine(number); // number = 2; // <-- Results in compile-time error