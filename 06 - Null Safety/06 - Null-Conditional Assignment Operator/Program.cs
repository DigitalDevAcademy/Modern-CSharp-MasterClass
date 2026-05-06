ReportOptions? reportOptions = new();

if (reportOptions is not null)
{
    reportOptions.Export = GetDefaultExportOptions();
}

reportOptions?.Export = GetDefaultExportOptions();

ExportOptions GetDefaultExportOptions()
{
    Console.WriteLine("Loading export options...");
    return new();
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