var fileDetails = string.Empty;
var fileSize = "4 KB";

/* Auto escaping backslashes, double quotes and more 
 * Also creating new lines with raw string literals
 * Introduced during C# 11 .NET 7
 */
Console.WriteLine("");
fileDetails = $"""
File Location: "C:\Documents\File.txt"
File Size: 4 KB
""";
Console.WriteLine(fileDetails);

Console.WriteLine();

// Interpolated raw strings literals have the above mentioned benefits + interpolation
Console.WriteLine("Interpolated Raw String Literals");
fileDetails = $"""
File Location: "C:\Documents\File.txt"
File Size: {fileSize}
""";
Console.WriteLine(fileDetails);