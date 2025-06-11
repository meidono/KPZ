namespace task2.Interfaces;

public interface IHero
{
    int Health { get; }
    int Attack { get; }
    int Defense { get; }
    string GetDescription();
    int GetPower() => Attack + Defense + Health / 10;
} 