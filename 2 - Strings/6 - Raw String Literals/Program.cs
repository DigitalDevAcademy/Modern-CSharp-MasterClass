var fileDetails = string.Empty;
var fileSize = "4 KB";

// Introduced during C# 11 .NET 7
Console.WriteLine("Raw String Literals");
fileDetails = $"""
File Location: "C:\Documents\File.txt"
File Size: 4 KB
""";
Console.WriteLine(fileDetails);

Console.WriteLine();

Console.WriteLine("Interpolated Raw String Literals");
fileDetails = $"""
File Location: "C:\Documents\File.txt"
File Size: {fileSize}
""";
Console.WriteLine(fileDetails);