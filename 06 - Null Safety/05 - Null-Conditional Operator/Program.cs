ReportOptions reportOptions = new() { Export = new() };

if (reportOptions.Export is not null && reportOptions.Export.Format == ExportFormat.Excel)
{
    Console.WriteLine("Exporting Excel report.");
}

if (reportOptions.Export?.Format == ExportFormat.Excel)
{
    Console.WriteLine("Exporting Excel report.");
}

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