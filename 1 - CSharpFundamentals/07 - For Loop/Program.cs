// Both have a predictable number of iterations

Console.WriteLine("--- Forward Iteration ---");
for (int page = 1; page <= 5; page++)
{
    Console.WriteLine(page);
}

Console.WriteLine("--- Backward Iteration ---");
for (int page = 5; page >= 1; page--)
{
    Console.WriteLine(page);
}
