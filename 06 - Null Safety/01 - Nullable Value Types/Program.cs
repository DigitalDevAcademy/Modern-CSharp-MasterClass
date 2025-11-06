Book book1 = new() { Title = "New Book", Author = "John Doe" };
Book book2 = new() { Title = "Established Book", Author = "Famous Author",  AverageRating = 5 };

PrintBookInfo(book1);
PrintBookInfo(book2);

void PrintBookInfo(Book book)
{
    if (book.AverageRating is double ar)
    {
        Console.WriteLine($"{book.Title} is written by {book.Author} and has a rating of {ar} stars");
    }
    else
    {
        Console.WriteLine($"{book.Title} is written by {book.Author}");
    }
}

class Book
{
    public required string Title { get; init; }

    public required string Author { get; init; }

    public double? AverageRating { get; init; }
}