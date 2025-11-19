ReportOptions reportOptions = new() { Title = "Annual Report", Export = new() { Format = ExportFormat.Html }};
ExportOptions fallbackExportOptions = new() { Format = ExportFormat.Word };

ResolveAndDisplayFormat(reportOptions, fallbackExportOptions);

void ResolveAndDisplayFormat(ReportOptions reportOptions, ExportOptions fallbackExportOptions)
{
    // Legacy
    // if (reportOptions.Export is null)
    // {
    //     reportOptions.Export = fallbackExportOptions;
    // }

    // Modern
    reportOptions.Export ??= fallbackExportOptions;

    Console.WriteLine($"Format: {reportOptions.Export.Format}");
}

class ReportOptions
{
    public required string Title { get; init; }

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