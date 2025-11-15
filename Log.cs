namespace BlueTimelapse;

public static class Log
{
    public static event Action<Level, string>? MessageLogged;
    
    public static void Info(string msg) => Write(Level.Info, msg);
    public static void Warning(string msg) => Write(Level.Warn, msg);
    public static void Error(string msg) => Write(Level.Error, msg);

    private static void Write(Level level, string msg)
    {
        Console.WriteLine($"[{level.ToString().ToUpper()}] {msg}");
        MessageLogged?.Invoke(level, msg);
    }

    public enum Level
    {
        Info,
        Warn,
        Error
    }
}