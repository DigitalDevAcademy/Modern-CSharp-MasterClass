// Only showcasing break in for loop, however it can be used in other types of loops

for (int page = 1; page <= 10; page++)
{
    if (page == 5) // Stop the loop when page is 5
    {
        break;
    }

    Console.WriteLine(page);
}