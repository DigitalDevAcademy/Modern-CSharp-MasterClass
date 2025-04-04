// Character - single symbol, uses single quotes
char letter = 'A';
Console.WriteLine(letter);

// String - sequence of characters, uses double quotes
string word = "Apple";
Console.WriteLine(word);

// Accessing a character from the string using indexing
char firstLetter = word[0];
Console.WriteLine(firstLetter);

// Getting the ASCII code of a character
int asciiCode = (int)firstLetter;
Console.WriteLine(asciiCode);

// Converting a char to string
string firstLetterAsString = firstLetter.ToString();
Console.WriteLine(firstLetterAsString);

// Get length of the string
int wordLength = word.Length;
Console.WriteLine(wordLength);

// Initialize an empty string
string emptyString = string.Empty;
Console.WriteLine(emptyString);

// Please note that char and string are different types
// char wrong = "A";            // This would cause an error
// string alsoWrong = 'C';      // This would also cause an error