// Only showcasing continue in for loop, however it can be used in other types of loops

for (int page = 1; page <= 10; page++)
{
    if (page == 5) // Skip page 5, continue the loop
    {
        continue;
    }

    Console.WriteLine(page);
}