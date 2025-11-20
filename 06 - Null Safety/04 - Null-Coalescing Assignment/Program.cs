ReportOptions reportOptions = new() { Export = new() { Format = ExportFormat.Html }};
ExportOptions exportOptionsFallback = new() { Format = ExportFormat.Word };

if (reportOptions.Export is null)
{
    reportOptions.Export = exportOptionsFallback;
}
Console.WriteLine($"Format: {reportOptions.Export.Format}");

reportOptions.Export ??= exportOptionsFallback;
Console.WriteLine($"Format: {reportOptions.Export.Format}");

class ReportOptions
{
    public ExportOptions? Export { get; set; }
}

class ExportOptions
{
    public ExportFormat Format { get; set; }
}

public enum ExportFormat
{
    Pdf,
    Word,
    Html
}