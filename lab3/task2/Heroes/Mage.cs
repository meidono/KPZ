using task2.Interfaces;

namespace task2.Heroes;

public class Mage : IHero
{
    public int Health => 80;
    public int Attack => 8;
    public int Defense => 3;

    public string GetDescription()
    {
        return $"Mage (Health: {Health}, Attack: {Attack}, Defense: {Defense})";
    }
} 