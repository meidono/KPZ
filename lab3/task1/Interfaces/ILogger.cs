namespace task1.Interfaces;

public interface ILogger
{
    void Log(string message);
    void Error(string message);
    void Warn(string message);
} 