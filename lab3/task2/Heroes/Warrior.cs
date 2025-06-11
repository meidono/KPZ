using task2.Interfaces;

namespace task2.Heroes;

public class Warrior : IHero
{
    public int Health => 100;
    public int Attack => 10;
    public int Defense => 5;

    public string GetDescription()
    {
        return $"Warrior (Health: {Health}, Attack: {Attack}, Defense: {Defense})";
    }
}