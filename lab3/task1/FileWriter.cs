namespace task1;

public class FileWriter
{
    private readonly string _filePath;

    public FileWriter(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
            throw new ArgumentNullException(nameof(filePath));
            
        _filePath = filePath;
    }

    public void Write(string text)
    {
        try
        {
            File.AppendAllText(_filePath, text);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
            throw;
        }
    }

    public void WriteLine(string text)
    {
        try
        {
            File.AppendAllText(_filePath, text + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
            throw;
        }
    }
}