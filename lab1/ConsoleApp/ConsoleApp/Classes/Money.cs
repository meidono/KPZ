using ConsoleApp.Interfaces;

namespace ConsoleApp.Classes
{
    public class Money: IMoney

    {
    public int Cash { get; set; }
    public int Cents { get; set; }


    public Money(int cash, int cents)
    {
        Cash = cash;
        Cents = cents;

    }

    public void SetCash(int cash, int cents)
    {
        Cash = cash;
        Cents = cents;
    }

    public override string ToString()
    {
        return $"Cash: {Cash}, Cents: {Cents}";
    }

    }
}

