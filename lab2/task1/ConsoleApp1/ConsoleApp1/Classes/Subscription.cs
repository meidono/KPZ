namespace ConsoleApp1.Classes;

using ConsoleApp1.Interfaces;



public abstract class Subscription : ISubscription
{
    public abstract string Name { get; }
    public abstract decimal MonthlyFee { get; }
    public abstract int MinimumPeriodMonths { get; }
    public abstract List<string> Channels { get; }
    public abstract List<string> Features { get; }

    public override string ToString()
    {
        return $"Назва: {Name},  Ціна: {MonthlyFee} грн/міс, Мінімальний період: {MinimumPeriodMonths} міс\n" +
               $"Канали: {string.Join(", ", Channels)}\n" +
               $"Функції: {string.Join(", ", Features)}";
    }
}
