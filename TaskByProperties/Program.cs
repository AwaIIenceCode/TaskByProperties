using System;
using System.Text; 

class Logger
{
    private StringBuilder _logs = new StringBuilder();
    public Logger() {}
    public string Message
    {
        set => _logs.AppendLine(value);
    }
    public void PrintLogs()
    {
        Console.WriteLine(_logs.ToString());
    }
    public void ClearLogs()
    {
        _logs.Clear();
        Console.WriteLine("Logs cleared!");
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