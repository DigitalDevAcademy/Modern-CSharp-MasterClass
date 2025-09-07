ProcessPayment(50, PaymentType.Crypto);

void ProcessPayment(decimal amount, PaymentType paymentType)
{
    switch(paymentType)
    {
        case PaymentType.Cash:
            Console.WriteLine($"Processing ${amount} through in-person exchange");
            break;
        case PaymentType.Bank:
            Console.WriteLine($"Processing ${amount} through bank transfer (ACH or Wire)");
            break;
        case PaymentType.Crypto:
            Console.WriteLine($"Processing ${amount} through blockchain transaction");
            break;
        default:
            Console.WriteLine("Unknown payment type");
            break;
    }
}

enum PaymentType
{
    Cash,
    Bank,
    Crypto
}