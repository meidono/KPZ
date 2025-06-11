using ConsoleApp1.Classes.Subscriptions;
using ConsoleApp1.Factories;
using ConsoleApp1.Interfaces;

class Program
{
    static void Main()
    {
        SubscriptionCreator website = new WebSite();
        SubscriptionCreator mobileApp = new MobileApp();
        SubscriptionCreator managerCall = new ManagerCall();

        ISubscription domestic = website.CreateSubscription();
        ISubscription educational = mobileApp.CreateSubscription();
        ISubscription premium = managerCall.CreateSubscription();

        Console.WriteLine(domestic);
        Console.WriteLine();
        Console.WriteLine(educational);
        Console.WriteLine();
        Console.WriteLine(premium);
    }
}