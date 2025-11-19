ReportOptions reportOptions = new() { Title = "Annual Report", Export = new() { Format = ExportFormat.Html }};

ResolveAndDisplayFormat(reportOptions);

void ResolveAndDisplayFormat(ReportOptions reportOptions)
{
    ExportOptions fallback = new() { Format = ExportFormat.Word };

    // if (reportOptions.Export is null)
    // {
    //     reportOptions.Export = fallback;
    // }

    reportOptions.Export ??= fallback;

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