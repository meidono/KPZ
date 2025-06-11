using System;

class Program
{
    static void Main(string[] args)
    {
        var emergencyHandler = new EmergencySupportHandler();
        var technicalHandler = new TechnicalSupportHandler();
        var billingHandler = new BillingSupportHandler();
        var generalHandler = new GeneralSupportHandler();

        emergencyHandler.SetNextHandler(technicalHandler);
        technicalHandler.SetNextHandler(billingHandler);
        billingHandler.SetNextHandler(generalHandler);

        while (true)
        {
            Console.WriteLine("\nВітаємо в системі підтримки користувачів!");
            Console.WriteLine("Опишіть вашу проблему:");
            string? request = Console.ReadLine();

            if (string.IsNullOrEmpty(request))
            {
                Console.WriteLine("Будь ласка, введіть опис проблеми.");
                continue;
            }

            bool handled = emergencyHandler.HandleRequest(request);

            if (!handled)
            {
                Console.WriteLine("Не вдалося визначити відповідний відділ підтримки. Спробуйте ще раз.");
            }

            Console.WriteLine("\nБажаєте продовжити? (так/ні)");
            string? continueResponse = Console.ReadLine()?.ToLower();
            if (continueResponse != "так")
            {
                break;
            }
        }
    }
}
