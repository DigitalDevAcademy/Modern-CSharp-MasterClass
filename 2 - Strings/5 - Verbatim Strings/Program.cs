var fileDetails = string.Empty;
var fileSize = "4 KB";

Console.WriteLine("Verbatim Strings");

fileDetails = @"File Location: ""C:\Documents\File.txt""
File Size: 4 KB";
Console.WriteLine(fileDetails);

Console.WriteLine();

// Introduced during C# 6 but after C# 8 .NET Core 3 ($@ or @$) order does not matter
Console.WriteLine("Interpolated Verbatim Strings");

fileDetails = $@"File Location: ""C:\Documents\File.txt"" 
File Size: {fileSize}";
Console.WriteLine(fileDetails);

fileDetails = @$"File Location: ""C:\Documents\File.txt"" 
File Size: {fileSize}";
Console.WriteLine(fileDetails);