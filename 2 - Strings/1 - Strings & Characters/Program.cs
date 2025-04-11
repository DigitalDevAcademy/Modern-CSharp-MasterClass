// char represents is character and uses single quotes - known as a character literal
char character = 'A';
Console.WriteLine(character);

// string represents a sequence of characters and uses double quotes - known as a string literal
string text = "Adventure";
Console.WriteLine(text);

// We can access a single character from the string using indexing
char firstCharacter = text[0];
Console.WriteLine(firstCharacter);

// We can retrieve the ASCII code of a character
int asciiCode = (int)firstCharacter;
Console.WriteLine(asciiCode);

// We can convert a char to string
string firstCharacterAsString = firstCharacter.ToString();
Console.WriteLine(firstCharacterAsString);

// We get the length of the string by using Length property
int textLength = text.Length;
Console.WriteLine(textLength);

// Initialize an empty string
string emptyText = string.Empty;
Console.WriteLine("[" + emptyText + "]");

// Important: char and string are different types
// char letter = "A";      // Error - we cannot auto-convert string to char
// string text = 'C';      // Error - we cannot auto-convert char to string