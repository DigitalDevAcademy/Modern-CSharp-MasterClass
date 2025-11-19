ReportOptions reportOptions = new() { Title = "Annual Report", };

AutoSetAndDisplayFormat(reportOptions);

void AutoSetAndDisplayFormat(ReportOptions reportOptions)
{
    ExportOptions custom = new() { Format = ExportFormat.Html };
    ExportOptions fallback = new() { Format = ExportFormat.Word };
    
    // if (custom is not null)
    // {
    //     reportOptions.Export = custom;
    // }
    // else
    // {
    //     reportOptions.Export = fallback;
    // }

    // reportOptions.Export = custom != null ? custom : fallback;

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