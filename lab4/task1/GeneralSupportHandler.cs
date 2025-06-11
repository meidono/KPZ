using System;

public class GeneralSupportHandler : Handler
{
    public override bool HandleRequest(string request)
    {
        Console.WriteLine("Чи є ваше питання загального характеру? (так/ні)");
        string? response = Console.ReadLine()?.ToLower();

        if (response == "так")
        {
            Console.WriteLine("Ваш запит передано до загальної підтримки.");
            return true;
        }

        return NextHandler?.HandleRequest(request) ?? false;
    }
} 