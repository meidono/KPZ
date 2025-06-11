using task1;
using task1.Interfaces;

var consoleLogger = new ConsoleLogger();
var fileLogger = new FileLoggerAdapter("log.txt");

Console.WriteLine("Testing Console Logger:");
consoleLogger.Log("This is a log message");
consoleLogger.Error("This is an error message");
consoleLogger.Warn("This is a warning message");

Console.WriteLine("\nTesting File Logger:");
fileLogger.Log("This is a log message");
fileLogger.Error("This is an error message");
fileLogger.Warn("This is a warning message");

Console.WriteLine("\nCheck log.txt file for file logger output"); 