using task4.Interfaces;

namespace task4;

public class SmartTextChecker : ISmartTextReader
{
    private readonly ISmartTextReader _reader;

    public SmartTextChecker(ISmartTextReader reader)
    {
        _reader = reader;
    }

    public char[][] ReadText(string filePath)
    {
        Console.WriteLine($"Opening file: {filePath}");
        
        try
        {
            var result = _reader.ReadText(filePath);
            
            var totalLines = result.Length;
            var totalChars = result.Sum(line => line.Length);
            
            Console.WriteLine($"Successfully read file: {filePath}");
            Console.WriteLine($"Total lines: {totalLines}");
            Console.WriteLine($"Total characters: {totalChars}");
            
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            throw;
        }
        finally
        {
            Console.WriteLine($"Closing file: {filePath}");
        }
    }
} 