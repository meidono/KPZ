namespace ConsoleApp1.Factories;
using ConsoleApp1.Classes.Subscriptions;
using ConsoleApp1.Interfaces;


    class WebSite : SubscriptionCreator 
    {
        public override ISubscription CreateSubscription()
        {
            return new DomesticSubscription();
        }
    }
