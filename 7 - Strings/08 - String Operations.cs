string text = "This is an example text.";
string substring = "example";
string untrimmedText = "  Example, Text!  ";

Console.WriteLine("String Searching");
Console.WriteLine(text.IndexOf(substring)); // Get index of first "example" in 'text'
Console.WriteLine(text.LastIndexOf("e")); // Get last index of "e" in 'text'
Console.WriteLine();

Console.WriteLine("String Matching");
Console.WriteLine(text.Contains("example")); // Check if "example" is in 'text'
Console.WriteLine(text.StartsWith("This")); // Check if 'text' starts with "This"
Console.WriteLine(text.EndsWith("text.")); // Check if 'text' ends with "text."
Console.WriteLine();

Console.WriteLine("String Modification");
Console.WriteLine(text.Replace("text", "sentence")); // Replace word "text" with "sentence"
Console.WriteLine(text.ToLower()); // Lowercase 'text'
Console.WriteLine(text.ToUpper()); // Uppercase 'text'
Console.WriteLine();

Console.WriteLine("String Validation");
Console.WriteLine(string.IsNullOrEmpty(string.Empty)); // Check if string is null or empty
Console.WriteLine(string.IsNullOrWhiteSpace(string.Empty)); // Check if string is null, empty, or spaces only
Console.WriteLine();

Console.WriteLine("String Cleanup");
Console.WriteLine("[" + untrimmedText.Trim() + "]"); // Trim spaces from start and end
Console.WriteLine("[" + untrimmedText.TrimStart() + "]"); // Trim spaces from start
Console.WriteLine("[" + untrimmedText.TrimEnd() + "]"); // Trim spaces from end
Console.WriteLine();

Console.WriteLine("String Comparison");
Console.WriteLine(string.Equals(substring, "example")); // Check if two strings are equal
Console.WriteLine();

Console.WriteLine("String Splitting");
string[] parts = text.Split(' '); // Split 'text' into parts based on space character
for (int i = 0; i < parts.Length; i++) 
{
    Console.WriteLine(parts[i]); // Print each part
}
Console.WriteLine();