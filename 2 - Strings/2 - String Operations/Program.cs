string text = "Hello, World! Welcome to C# String Operations."; // Main string to work with
string sub = "World"; // Substring to check for
string untrimmedText = "  Hello, World!  "; // String with extra spaces
string[] wordList = ["Hello", "World", "!"]; // Example word list for joining

Console.WriteLine("String Comparison & Matching");
Console.WriteLine(text.StartsWith("Hello")); // Check if 'text' starts with "Hello"
Console.WriteLine(text.EndsWith("Operations.")); // Check if 'text' ends with "Operations."
Console.WriteLine(string.Equals(sub, "World")); // Compare two strings for equality
Console.WriteLine(string.IsNullOrEmpty(string.Empty)); // Check if string is null or empty
Console.WriteLine(string.IsNullOrWhiteSpace(string.Empty)); // Check if string is null, empty, or only spaces
Console.WriteLine();

Console.WriteLine("String Searching");
Console.WriteLine(text.IndexOf(sub)); // Get index of first "World" in 'text'
Console.WriteLine(text.LastIndexOf("o")); // Get last index of "o" in 'text'
Console.WriteLine(text.Contains("Welcome")); // Check if "Welcome" is in 'text'
Console.WriteLine();

Console.WriteLine("String Modification & Cleanup");
Console.WriteLine(text.Replace("World", "Universe")); // Replace "World" with "Universe"
Console.WriteLine(text.ToLower()); // Convert text variable to lowercase
Console.WriteLine(text.ToUpper()); // Convert text variable to uppercase
Console.WriteLine("[" + untrimmedText.Trim() + "]"); // Trim spaces from both ends and show result
Console.WriteLine("[" + untrimmedText.TrimStart() + "]"); // Trim spaces from start only
Console.WriteLine("[" + untrimmedText.TrimEnd() + "]"); // Trim spaces from end only
Console.WriteLine();

Console.WriteLine("String Breaking & Building");

string[] parts = text.Split(' '); // Split 'text' into words using space
for (int i = 0; i < parts.Length; i++) // Print each part using a for loop
{
    Console.WriteLine(parts[i]);
}

Console.WriteLine(text.Substring(0, 5)); // Get substring starting at index 0 with length 5
Console.WriteLine(string.Join(" ", wordList)); // Join the word list into one string with spaces
Console.WriteLine();