var fileDetails = string.Empty;
var fileSize = "4 KB";

// Auto escaping backslashes and creating new lines with verbatim strings
fileDetails = @"File Location: ""C:\Documents\File.txt""
File Size: 4 KB";
Console.WriteLine(fileDetails);

Console.WriteLine();

/* Interpolated verbatim strings have the above mentioned benefits + interpolation
 * These were introduced during C# 6 but after C# 8 .NET Core 3 
 * ($@ or @$) order does not matter
 */
fileDetails = $@"File Location: ""C:\Documents\File.txt"" 
File Size: {fileSize}";
Console.WriteLine(fileDetails);

fileDetails = @$"File Location: ""C:\Documents\File.txt"" 
File Size: {fileSize}";
Console.WriteLine(fileDetails);