ConsoleLogger.LogInfo("This is just a message");

ConsoleLogger.LogWarning("Might not be able to process the file");

ConsoleLogger.LogError("Application stopped working ");

static class ConsoleLogger
{
    public static void LogInfo(string message) => Console.WriteLine($"[INFO] {message}");

    public static void LogWarning(string message) => Console.WriteLine($"[WARNING] {message}!");

    public static void LogError(string message) => Console.WriteLine($"[ERROR] {message}!!!");
}