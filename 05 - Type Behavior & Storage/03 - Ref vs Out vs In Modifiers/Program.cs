int firstNumber = 1;
ChangeUsingRef(ref firstNumber);
void ChangeUsingRef(ref int number) => number = 2;
Console.WriteLine(firstNumber);

var result = ChangeUsingOut(out int secondNumber);
bool ChangeUsingOut(out int number)
{
    number = 2;
    return true;
}
Console.WriteLine($"{result} - {secondNumber}");

int thirdNumber = 1;
AccessUsingIn(in thirdNumber);
void AccessUsingIn(in int number) => Console.WriteLine(number); // number = 2; // <-- Results in compile-time error