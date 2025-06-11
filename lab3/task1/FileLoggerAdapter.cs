using task1.Interfaces;

namespace task1;

public class FileLoggerAdapter : ILogger
{
    private readonly FileWriter _fileWriter;

    public FileLoggerAdapter(string filePath)
    {
        _fileWriter = new FileWriter(filePath);
    }

    public void Log(string message)
    {
        _fileWriter.WriteLine($"[LOG] {message}");
    }

    public void Error(string message)
    {
        _fileWriter.WriteLine($"[ERROR] {message}");
    }

    public void Warn(string message)
    {
        _fileWriter.WriteLine($"[WARN] {message}");
    }
} 