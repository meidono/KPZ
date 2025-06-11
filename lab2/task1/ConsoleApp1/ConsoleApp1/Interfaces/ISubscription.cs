
namespace ConsoleApp1.Interfaces
{
    public interface ISubscription
    {
        string Name { get; }
        decimal MonthlyFee { get; }
        int MinimumPeriodMonths { get; }
        List<string> Channels { get; }
        List<string> Features { get; }
        
    }  
}

