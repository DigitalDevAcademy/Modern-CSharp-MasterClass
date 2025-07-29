using System.Text;

string[] reportParts = ["many", "parts", "of", "a", "report"];

StringBuilder sb = new();

// This is how you set the capacity
// StringBuilder sb = new(500);

// This is how you set an initial string and set the capacity
// StringBuilder sb = new("Some initial value", 500);

for (int i = 0; i < reportParts.Length; i++)
{
    sb.AppendLine(reportParts[i]);
    // finalReport += reportParts[i] // This would create multiple copies
}

// Printing the full version of the report
Console.WriteLine(sb.ToString());