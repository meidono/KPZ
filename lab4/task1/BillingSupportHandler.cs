using System;

public class BillingSupportHandler : Handler
{
    public override bool HandleRequest(string request)
    {
        Console.WriteLine("Чи пов'язана ваша проблема з оплатою або рахунками? (так/ні)");
        string? response = Console.ReadLine()?.ToLower();

        if (response == "так")
        {
            Console.WriteLine("Ваш запит передано до відділу бухгалтерії.");
            return true;
        }

        return NextHandler?.HandleRequest(request) ?? false;
    }
} 