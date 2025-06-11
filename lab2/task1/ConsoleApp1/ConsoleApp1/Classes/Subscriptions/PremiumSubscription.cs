namespace ConsoleApp1.Classes.Subscriptions;

public class PremiumSubscription : Subscription
{
    public override string Name => "Premium";
    public override decimal MonthlyFee => 199;
    public override int MinimumPeriodMonths => 1;
    public override List<string> Channels => new() { "Усе включено", "Спорт", "Кіно", "4K Канали" };
    public override List<string> Features => new() { "4K", "10 пристроїв", "Офлайн-доступ" };
    
}