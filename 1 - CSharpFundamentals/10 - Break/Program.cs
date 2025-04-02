// Only showcasing break in for loop, however it can be used in other types of loops

for (int page = 1; page <= 5; page++)
{
    if (page == 3) // Stop the loop when page is 3
    {
        break;
    }

    Console.WriteLine(page);
}