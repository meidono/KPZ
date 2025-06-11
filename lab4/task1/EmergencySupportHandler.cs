using System;

public class EmergencySupportHandler : Handler
{
    public override bool HandleRequest(string request)
    {
        Console.WriteLine("Чи є ваша проблема терміновою? (так/ні)");
        string? response = Console.ReadLine()?.ToLower();

        if (response == "так")
        {
            Console.WriteLine("Ваш запит передано до термінової підтримки.");
            return true;
        }

        return NextHandler?.HandleRequest(request) ?? false;
    }
} 