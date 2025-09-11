string text = "I just learned modern C#";
string substring = "modern";
string untrimmedText = "  Example, Text!  ";

Console.WriteLine(text.IndexOf(substring));
Console.WriteLine(text.Contains("learned"));
Console.WriteLine(text.StartsWith("I"));
Console.WriteLine(text.EndsWith("C#"));
Console.WriteLine(text.Replace("learned", "mastered"));
Console.WriteLine(text.ToLower());
Console.WriteLine(text.ToUpper());
Console.WriteLine(string.IsNullOrEmpty(string.Empty));
Console.WriteLine(string.IsNullOrWhiteSpace("   "));
Console.WriteLine("[" + untrimmedText.Trim() + "]");
Console.WriteLine("[" + untrimmedText.TrimStart() + "]");
Console.WriteLine("[" + untrimmedText.TrimEnd() + "]");

string[] parts = text.Split(' ');
foreach (string part in parts) 
{
    Console.WriteLine(part);
}

string joinedTextByWhiteSpaces = string.Join(" ", parts);
string joinedTextByDashes = string.Join("-", parts);

Console.WriteLine(joinedTextByWhiteSpaces);
Console.WriteLine(joinedTextByDashes);

char[] textToCharArray = text.ToCharArray();
foreach (char character in textToCharArray)
{
    Console.WriteLine(character);
}