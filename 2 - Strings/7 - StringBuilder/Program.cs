using System.Text;

string[] reportParts = ["many", "parts", "of", "a", "report"];
var immutableString = string.Empty;
var stringBuilder = new StringBuilder();

Console.WriteLine("String Concatenation");
for(int i = 0; i < reportParts.Length; i++)
{
    var reportPart = reportParts[i];
    immutableString += reportPart;
    immutableString += "\n";
}
Console.WriteLine(immutableString);

Console.WriteLine("StringBuilder");
for (int i = 0; i < reportParts.Length; i++)
{
    var reportPart = reportParts[i];
    stringBuilder.AppendLine(reportPart);

}
Console.WriteLine(stringBuilder.ToString());
