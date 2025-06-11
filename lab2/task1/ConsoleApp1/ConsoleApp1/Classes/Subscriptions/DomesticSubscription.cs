namespace ConsoleApp1.Classes.Subscriptions;

public class DomesticSubscription : Subscription
{
    public override string Name => "Domestic";
    public override decimal MonthlyFee => 99;
    public override int MinimumPeriodMonths => 1;
    public override List<string> Channels => new() { "Новини", "Кіно", "Музика" };
    public override List<string> Features => new() { "HD", "2 пристрої" };
}
