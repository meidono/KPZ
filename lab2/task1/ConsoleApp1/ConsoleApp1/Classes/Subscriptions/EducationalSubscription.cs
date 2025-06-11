namespace ConsoleApp1.Classes.Subscriptions;

public class EducationalSubscription : Subscription
{
    public override string Name => "Educational";
    public override decimal MonthlyFee => 49;
    public override int MinimumPeriodMonths => 3;
    public override List<string> Channels => new() { "Освіта", "Наука", "Документалістика" };
    public override List<string> Features => new() { "Без реклами" };
}