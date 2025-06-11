namespace task6;

class Program
{
    static void Main(string[] args)
    {
        var sampleText = new[]
        {
            "Пригоди Тома Сойєра",
            "Марк Твен",
            "Глава 1",
            "Том грається",
            "Том Сойєр був звичайним хлопчиськом, який любив гратися та придумувати різні витівки.",
            "    Він часто тікав зі школи, щоб поплавати в річці або зловити рибу.",
            "Його найкращий друг",
            "Гекльберрі Фінн був його найкращим другом. Вони разом пережили багато пригод."
        };

        var converter = new TextToHTMLConverter();
        var html = converter.ConvertToHTML(sampleText);

        Console.WriteLine("HTML верстка:");
        Console.WriteLine(html.OuterHTML);
        
        Console.WriteLine($"\nКількість унікальних елементів: {LightHTMLFactory.GetTotalElementsCount()}");
        
        var memoryBefore = GC.GetTotalMemory(false);
        var html2 = converter.ConvertToHTML(sampleText);
        var memoryAfter = GC.GetTotalMemory(false);
        
        Console.WriteLine($"\nВикористання пам'яті: {(memoryAfter - memoryBefore) / 1024.0:F2} KB");
    }
} 