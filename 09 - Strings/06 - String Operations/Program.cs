string text = "I just learned modern C#";
string substring = "modern";
string untrimmedText = "  Example, Text!  ";

// Time .NET runtime dependent, O(1) space
Console.WriteLine(text.IndexOf(substring));

// Time .NET runtime dependent, O(1) space
Console.WriteLine(text.Contains("learned"));

// O(v) time, O(1) space
Console.WriteLine(text.StartsWith("I"));

// O(v) time, O(1) space
Console.WriteLine(text.EndsWith("C#"));

// Time .NET runtime dependent, O(m) space
Console.WriteLine(text.Replace("learned", "mastered"));

// O(n) time, O(n) space
Console.WriteLine(text.ToLower());

// O(n) time, O(n) space
Console.WriteLine(text.ToUpper());

// O(1) time, O(1) space
Console.WriteLine(string.IsNullOrEmpty(string.Empty));

// O(n) time, O(1) space
Console.WriteLine(string.IsNullOrWhiteSpace("   "));

// O(n) time, O(m) space
Console.WriteLine("[" + untrimmedText.Trim() + "]");

// O(n) time, O(m) space
Console.WriteLine("[" + untrimmedText.TrimStart() + "]");

// O(n) time, O(m) space
Console.WriteLine("[" + untrimmedText.TrimEnd() + "]");

// O(n) time, O(n) space
string[] parts = text.Split(' ');
foreach (string part in parts) 
{
    Console.WriteLine(part);
}

// O(m) time, O(m) space
string joinedTextByWhiteSpaces = string.Join(' ', parts);
string joinedTextByDashes = string.Join('-', parts);

Console.WriteLine(joinedTextByWhiteSpaces);
Console.WriteLine(joinedTextByDashes);

// O(n) time, O(n) space
char[] textToCharArray = text.ToCharArray();
foreach (char character in textToCharArray)
{
    Console.WriteLine(character);
}