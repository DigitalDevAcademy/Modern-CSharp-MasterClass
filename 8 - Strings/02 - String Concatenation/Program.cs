var username = Console.ReadLine();
string[] wordList = ["Welcome", "World", "!"];

// String concatenation using + (or +=) operator
Console.WriteLine("Welcome back, " + username + "!");

Console.WriteLine();

// String concatenation using string.Concat - either individual strings or an array of strings
Console.WriteLine(string.Concat("Welcome back, ", username, "!"));
Console.WriteLine(string.Concat(wordList));

Console.WriteLine();

// String concatenation using string.Join - uses a separator to concatenate strings
Console.WriteLine(string.Join(" ", wordList));