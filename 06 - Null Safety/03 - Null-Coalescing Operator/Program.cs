ReportOptions reportOptions = new();
ExportOptions? custom = null;
ExportOptions fallback = new() { Format = ExportFormat.Word };

if (custom is not null)
{
    reportOptions.Export = custom;
}
else
{
    reportOptions.Export = fallback;
}
Console.WriteLine($"Format: {reportOptions.Export.Format}");

reportOptions.Export = custom is not null ? custom : fallback;
Console.WriteLine($"Format: {reportOptions.Export.Format}");

reportOptions.Export = custom ?? fallback;
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