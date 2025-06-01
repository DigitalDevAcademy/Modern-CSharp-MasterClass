// O(1) time - both declaration and printing of the value are constant operations
var number = 10;
Console.WriteLine(number);

// O(n) time – number of operations grows at the same rate as 'itemLimit'
var itemLimit = 10;
for (int i = 0; i < itemLimit; i++)
{
    Console.WriteLine($"Processing item{i}.");
}

// O(n + m) – number of operations grows at the same rate as 'firstRunLimit' and 'secondRunLimit' - sequentially
var firstRunLimit = 10;
for (int i = 0; i < firstRunLimit; i++)
{
    Console.WriteLine($"First run of all items - run({i})");
}

var secondRunLimit = 5;
for (int i = 0; i < secondRunLimit; i++)
{
    Console.WriteLine($"Second run of all items - run({i})");
}

/// For each row, we go through all columns, making this O(n * m) – or O(r * c) to keep it clear
var totalColumns = 10;
var totalRows = 5;
for (int row = 0; row < totalRows; row++)
{
    for (int col = 0; col < totalColumns; col++)
    {
        Console.WriteLine($"Processing  Row{row} - Col{col}.");
    }
}



