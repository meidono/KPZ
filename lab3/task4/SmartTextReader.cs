using task4.Interfaces;

namespace task4;

public class SmartTextReader : ISmartTextReader
{
    public char[][] ReadText(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        return lines.Select(line => line.ToCharArray()).ToArray();
    }
} 