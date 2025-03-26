Console.WriteLine("--- Loop With Break ---");
for (int page = 1; page <= 5; page++)
{
    if (page == 3) // Stop the loop when page is 3
    {
        break;
    }

    Console.WriteLine(page);
}

Console.WriteLine("--- Loop With Continue ---");
for (int page = 1; page <= 5; page++)
{
    if (page == 3) // Skip page 3 and continue the loop
    {
        continue;
    }

    Console.WriteLine(page);
}