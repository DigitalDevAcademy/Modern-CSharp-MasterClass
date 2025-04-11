var username = Console.ReadLine();
string[] wordList = ["Welcome", "World", "!"];

Console.WriteLine("+ or += Operator");
Console.WriteLine("Welcome back, " + username + "!");

Console.WriteLine();

Console.WriteLine("String.Concat Method");
Console.WriteLine(string.Concat("Welcome back, ", username, "!"));
Console.WriteLine(string.Concat(wordList));

Console.WriteLine();

Console.WriteLine("String.Join Method");
Console.WriteLine(string.Join(" ", wordList));
