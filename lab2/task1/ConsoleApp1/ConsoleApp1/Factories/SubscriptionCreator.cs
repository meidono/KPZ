using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Factories
{
  abstract class SubscriptionCreator 
    {
        public abstract ISubscription CreateSubscription();
    }

}