// All space complexities here are O(1) - in real scenarios, space use would likely be higher during processing
Method1(10);
Method2(10);
Method3(5, 10);
Method4(5, 10);

// O(1) time - both declaration and printing of the value are constant operations
void Method1(int input) => Console.WriteLine(input);

// O(n) time – number of operations grows at the same rate as 'itemLimit'
void Method2(int input)
{
    for (int i = 0; i < input; i++)
    {
        Console.WriteLine($"Processing item{i}.");
    }
}

// O(n + m) time – number of operations grow at the same rate as 'input1' and 'input2' - sequentially
void Method3(int input1, int input2)
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

// For each row, we go through all columns, making this O(n * m) time – or O(r * c) time to keep it clear
void Method4(int input1, int input2)
{
    for (int row = 0; row < input1; row++)
    {
        for (int col = 0; col < input2; col++)
        {
            Console.WriteLine($"Processing  Row{row} - Col{col}.");
        }
    }
}