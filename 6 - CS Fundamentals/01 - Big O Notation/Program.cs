// All space complexities here are O(1) - in real scenarios, space use would likely be higher during processing
Work1(10);
Work2(10);
Work3(5, 10);
Work4(5, 10);

// O(1) time
void Work1(int input) => Console.WriteLine(input);

// O(n) time
void Work2(int input)
{
    for (int i = 0; i < input; i++)
    {
        Console.WriteLine($"Processing item{i}.");
    }
}

// O(n + m) time
void Work3(int input1, int input2)
{
    for (int i = 0; i < input1; i++)
    {
        Console.WriteLine($"First run of all items - run({i})");
    }

    for (int i = 0; i < input2; i++)
    {
        Console.WriteLine($"Second run of all items - run({i})");
    }
}

// O(n * m) or O(r * c) time to keep it clear
void Work4(int input1, int input2)
{
    for (int row = 0; row < input1; row++)
    {
        for (int col = 0; col < input2; col++)
        {
            Console.WriteLine($"Processing  Row{row} - Col{col}.");
        }
    }
}