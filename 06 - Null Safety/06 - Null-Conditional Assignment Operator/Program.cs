ReportOptions reportOptions = new();

if (reportOptions.Export is not null)
{
    reportOptions.Export.Format = ExportFormat.Word;
}
Console.WriteLine($"Format: {reportOptions.Export?.Format}");

reportOptions.Export?.Format = ExportFormat.Word;
Console.WriteLine($"Format: {reportOptions.Export?.Format}");

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