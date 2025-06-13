using System.Collections.Generic;

namespace ConsoleApp101;

public class NotificationManager
{
    private readonly List<ILogger> loggers = new();

    public void AddLogger(ILogger logger)
    {
        loggers.Add(logger);
    }

    public void Log(string message)
    {
        foreach (var logger in loggers)
            logger.Log(message);
    }

    public void Alert(string alert)
    {
        foreach (var logger in loggers)
            logger.Alert(alert);
    }
}
