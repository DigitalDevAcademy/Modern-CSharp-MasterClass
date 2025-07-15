using System.Text;

// This simple list could be something we get from a database or another source
string[] reportParts = ["many", "parts", "of", "a", "report"];

// Initializing a new StringBuilder
StringBuilder sb = new();

// This is how you set the capacity
// StringBuilder sb = new(500);

// This is how you set an initial string and set the capacity
// StringBuilder sb = new("Some initial value", 500);

// Iterating through parts of the report to build the full version
for (int i = 0; i < reportParts.Length; i++)
{
    sb.AppendLine(reportParts[i]);
    // finalReport += reportParts[i] // This would create multiple copies
}

// Printing the full version of the report
Console.WriteLine(sb.ToString());