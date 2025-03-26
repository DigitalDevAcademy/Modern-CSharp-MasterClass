var input = Console.ReadLine();
Console.WriteLine(input);

// The while loop will run an unknown number of times — everything depends on the user's input
while (!string.IsNullOrEmpty(input))
{
    input = Console.ReadLine();
    Console.WriteLine(input);
}