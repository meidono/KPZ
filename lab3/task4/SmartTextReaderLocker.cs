using System.Text.RegularExpressions;
using task4.Interfaces;

namespace task4;

public class SmartTextReaderLocker : ISmartTextReader
{
    private readonly ISmartTextReader _reader;
    private readonly Regex _restrictedPattern;

    public SmartTextReaderLocker(ISmartTextReader reader, string restrictedPattern)
    {
        _reader = reader;
        _restrictedPattern = new Regex(restrictedPattern);
    }

    public char[][] ReadText(string filePath)
    {
        if (_restrictedPattern.IsMatch(filePath))
        {
            Console.WriteLine("Access denied!");
            return Array.Empty<char[]>();
        }

        return _reader.ReadText(filePath);
    }
} 