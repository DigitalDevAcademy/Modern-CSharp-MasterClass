ReportOptions reportOptions1 = new() { Title = "Annual Report 1", Export = new()};
ReportOptions reportOptions2 = new() { Title = "Annual Report 2", };

ExportReport(reportOptions1);
ExportReport(reportOptions2);

void ExportReport(ReportOptions reportOptions)
{
    Console.WriteLine(reportOptions.Title);
    
    // Legacy
    // if (reportOptions.Export != null && reportOptions.Export.Format == ExportFormat.Pdf)
    // {
    //     Console.WriteLine("Exporting PDF report.");
    // }

    // Modern
    if (reportOptions.Export?.Format == ExportFormat.Pdf)
    {
        Console.WriteLine("Exporting PDF report.");
    }
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