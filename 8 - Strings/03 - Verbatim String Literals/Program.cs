var fileDetails = string.Empty;
var fileSize = "4 KB";

fileDetails = @"File Location: ""C:\Documents\File.txt""
                File Size: 4 KB";
Console.WriteLine(fileDetails);

fileDetails = $@"File Location: ""C:\Documents\File.txt"" 
                 File Size: {fileSize}
                 {{ No interpolated }}";
Console.WriteLine(fileDetails);

fileDetails = @$"File Location: ""C:\Documents\File.txt"" 
                 File Size: {fileSize}
                 {{ No interpolated }}";
Console.WriteLine(fileDetails);