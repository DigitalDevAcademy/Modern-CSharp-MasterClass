using System.Text;

string[] reportParts = ["many", "parts", "of", "a", "report"];

StringBuilder sb = new();

// This is how you set the capacity
// StringBuilder sb2 = new(500);

// This is how you set an initial string and set the capacity
// StringBuilder sb3 = new("Some initial value", 500);

foreach (string reportPart in reportParts)
{
    sb.AppendLine(reportPart);
}

Console.WriteLine(sb.ToString());