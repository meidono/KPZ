using System;

public class TechnicalSupportHandler : Handler
{
    public override bool HandleRequest(string request)
    {
        Console.WriteLine("Чи пов'язана ваша проблема з технічними аспектами? (так/ні)");
        string? response = Console.ReadLine()?.ToLower();

        if (response == "так")
        {
            Console.WriteLine("Ваш запит передано до технічної підтримки.");
            return true;
        }

        return NextHandler?.HandleRequest(request) ?? false;
    }
} 