namespace task4;

public static class ResultPrinter
{
    public static void PrintResult(char[][] result)
    {
        if (result.Length == 0)
        {
            Console.WriteLine("No content to display.");
            return;
        }

        Console.WriteLine("File content:");
        foreach (var line in result)
        {
            Console.WriteLine(new string(line));
        }
    }
} 