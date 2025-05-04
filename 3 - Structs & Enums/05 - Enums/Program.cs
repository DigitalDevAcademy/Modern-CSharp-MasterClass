string paymentType2 = "Credit";
Console.WriteLine(paymentType2);

int paymentType3 = 11;
Console.WriteLine(paymentType3);

PaymentType paymentType1 = PaymentType.Credit;
Console.WriteLine(paymentType1);
Console.WriteLine((int)paymentType1);

// Provides us with compile-time safety and keeps code refactor-friendly
if (paymentType1 == PaymentType.Credit)
{
    Console.WriteLine("Credit payment");
}

switch(paymentType1)
{
    case PaymentType.Credit:
        Console.WriteLine("Credit payment");
        break;
}

enum PaymentType
{
    None = 0, // Automatically assigned the value zero (since it has no initializer and is the first enum member)
    Cash,
    Crypto = 10, // Explicitly setting to 10
    Credit // Auto-increments by one from the previous value
}