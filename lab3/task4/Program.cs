using task4;
using task4.Interfaces;

public class Program
{
    public static void Main()
    {
        var reader = new SmartTextReader();
        var checker = new SmartTextChecker(reader);
        var locker = new SmartTextReaderLocker(checker, @"\.(txt|doc)$");

        Console.WriteLine("Testing SmartTextChecker:");
        Console.WriteLine();
        var result1 = checker.ReadText("test.txt");
        ResultPrinter.PrintResult(result1);

        Console.WriteLine("\nTesting SmartTextReaderLocker with allowed file:");
        Console.WriteLine();
        var result2 = locker.ReadText("test.txt");
        ResultPrinter.PrintResult(result2);

        Console.WriteLine("\nTesting SmartTextReaderLocker with restricted file:");
        Console.WriteLine();
        var result3 = locker.ReadText("restricted.txt");
        ResultPrinter.PrintResult(result3);
    }
} 