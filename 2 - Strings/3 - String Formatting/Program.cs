var username = Console.ReadLine();

Console.WriteLine("String.Format Method");
Console.WriteLine(string.Format("Welcome back, {0}!", username));
Console.WriteLine("Welcome back, {0}!", username);

Console.WriteLine();

// During C# 10 .NET 6 string interpolation has been dramatically improved
Console.WriteLine("String Interpolation");
Console.WriteLine($"Welcome back, {username}!");