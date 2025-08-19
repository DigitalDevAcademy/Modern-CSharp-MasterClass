ConsoleLogger.LogInfo("This is just a message");

ConsoleLogger.LogWarning("Please check something, this is a warning");

ConsoleLogger.LogError("Application stopped, error occured");

static class ConsoleLogger
{
    public static void LogInfo(string message) => Console.WriteLine($"[INFO] {message}");

    public static void LogWarning(string message) => Console.WriteLine($"[WARNING] {message}!");

    public static void LogError(string message) => Console.WriteLine($"[ERROR] {message}!!!");
}