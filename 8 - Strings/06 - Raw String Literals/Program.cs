var fileDetails = string.Empty;
var fileSize = "4 KB";

/* Auto escaping backslashes, double quotes and more 
 * Also creating new lines with raw string literals
 * Introduced during C# 11 .NET 7
 */
fileDetails = $""" 
    File Location: "C:\Documents\File.txt"
    File Size: 4 KB
    """;
Console.WriteLine(fileDetails);

Console.WriteLine();

// Interpolated raw strings literals have the above mentioned benefits + interpolation
fileDetails = $$""""
    File Location: "C:\Documents\File.txt"
    File Size: {{{fileSize}}}
    """ More file information """
    { Not interpolated }
    """";
Console.WriteLine(fileDetails);