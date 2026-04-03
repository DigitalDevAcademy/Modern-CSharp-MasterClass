ReportOptions reportOptions = new() { Export = new() };
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
    public ExportFormat Format { get; set; } = ExportFormat.Excel;
}

public enum ExportFormat
{
    Excel,
    Word
}