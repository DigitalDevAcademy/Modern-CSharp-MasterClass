ReportOptions reportOptions1 = new() { Title = "Annual Report 1", Export = new()};
ReportOptions reportOptions2 = new() { Title = "Annual Report 2", };

SetAndDisplayFormat(reportOptions1, ExportFormat.Html);
SetAndDisplayFormat(reportOptions2, ExportFormat.Html);

void SetAndDisplayFormat(ReportOptions reportOptions, ExportFormat format)
{
    Console.WriteLine(reportOptions.Title);

    // Legacy
    // if (reportOptions.Export is not null)
    // {
    //     reportOptions.Export.Format = format;
    // }

    // Modern
    reportOptions.Export?.Format = format;

    Console.WriteLine($"Format: {reportOptions.Export?.Format}");
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