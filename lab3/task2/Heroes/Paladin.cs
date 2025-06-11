using task2.Interfaces;

namespace task2.Heroes;

public class Paladin : IHero
{
    public int Health => 90;
    public int Attack => 9;
    public int Defense => 6;

    public string GetDescription()
    {
        return $"Paladin (Health: {Health}, Attack: {Attack}, Defense: {Defense})";
    }
} 