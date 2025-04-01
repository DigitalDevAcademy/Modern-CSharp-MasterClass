// Only showcasing continue in for loop, however it can be used in other types of loops

Console.WriteLine("--- Loop With Continue ---");
for (int page = 1; page <= 5; page++)
{
    if (page == 3) // Skip page 3 and continue the loop
    {
        continue;
    }

    Console.WriteLine(page);
}