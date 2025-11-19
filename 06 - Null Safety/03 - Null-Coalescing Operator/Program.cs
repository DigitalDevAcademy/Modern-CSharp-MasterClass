ReportOptions reportOptions = new() { Title = "Annual Report", };

ExportOptions customExportOptions = new() { Format = ExportFormat.Html };
ExportOptions fallbackExportOptions = new() { Format = ExportFormat.Word };

SetAndDisplayFormat(reportOptions, customExportOptions, fallbackExportOptions);

void SetAndDisplayFormat(ReportOptions reportOptions, ExportOptions custom, ExportOptions fallback)
{
    // Legacy
    // if (customExportOptions is not null)
    // {
    //     reportOptions.Export = custom; 
    // }
    // else
    // {
    //     reportOptions.Export = fallback;
    // }

    // reportOptions.Export = custom != null ? custom : fallback;

    // Modern
    reportOptions.Export = custom ?? fallback;

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