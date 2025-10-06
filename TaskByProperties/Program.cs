using System;

class Logger
{
    private string _logs;
    public Logger(string logs)
    {
        this._logs = logs;
    }
    public string Message
    { set => _logs += value + "\n"; }

    public string Description => _logs;
    public void PrintLogs()
    {
        Console.WriteLine($"Log: {Description}");
    }

    public void ClearLogs()
    {
        _logs = string.Empty;
        Console.WriteLine("\nLogs cleared");
    }
}
class Program
{
    static void Main()
    {
        Logger logger_1 = new Logger("Player joined the game");
        Logger logger_2 = new Logger("Player defeated enemy");
        Logger logger_3 = new Logger("Game saved");

        Logger[] loggers = { logger_1, logger_2, logger_3 };

        foreach (var logger in loggers)
        {
            logger.PrintLogs();
        }
        
        logger_2.ClearLogs();
        logger_2.PrintLogs();
    }
}