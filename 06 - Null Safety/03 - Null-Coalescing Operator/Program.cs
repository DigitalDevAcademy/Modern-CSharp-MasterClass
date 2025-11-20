ReportOptions reportOptions = new();
ExportOptions? exportOptions = new () { Format = ExportFormat.Html };
ExportOptions exportOptionsFallback = new() { Format = ExportFormat.Word };

if (exportOptions is not null)
{
    reportOptions.Export = exportOptions;
}
else
{
    reportOptions.Export = exportOptionsFallback;
}
Console.WriteLine($"Format: {reportOptions.Export.Format}");

reportOptions.Export = exportOptions is not null ? exportOptions : exportOptionsFallback;
Console.WriteLine($"Format: {reportOptions.Export.Format}");

reportOptions.Export = exportOptions ?? exportOptionsFallback;
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