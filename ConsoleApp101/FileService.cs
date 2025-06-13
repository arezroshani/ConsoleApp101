using System.IO;

namespace ConsoleApp101;

public class FileService : ILogger
{
    private readonly string filePath;

    public FileService(string filePath)
    {
        this.filePath = filePath;
    }

    public void Log(string message)
    {
        using StreamWriter writer = new StreamWriter(filePath, true);
        writer.WriteLine(message);
    }

    public void Alert(string alert)
    {
        Log(alert);
    }
}
