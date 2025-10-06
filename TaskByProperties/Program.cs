using System;

class Logger
{
    private string _logs = String.Empty;
    public Logger() {}
    public string Message
    { set => _logs += value + "\n"; }
    public void PrintLogs()
    {
        Console.WriteLine(_logs);
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
        Logger logger = new Logger();
        logger.Message = "Player joined the game";
        logger.Message = "Player defeated enemy";
        logger.Message = "Game saved";

        logger.PrintLogs();

        logger.ClearLogs();
        logger.PrintLogs();
    }
}