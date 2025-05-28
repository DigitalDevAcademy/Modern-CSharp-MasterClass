var username = Console.ReadLine();

// String formatting using string.Format
Console.WriteLine(string.Format("Welcome back, {0}!", username));
Console.WriteLine("Welcome back, {0}!", username);

Console.WriteLine();

/* String formatting using string interpolation
 * During C# 10 .NET 6 string interpolation has been dramatically improved
 */
Console.WriteLine($"Welcome back, {username}!");