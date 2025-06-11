using task2.Interfaces;
using task2.Decorators;

namespace task2.Items;

public class Armor : HeroDecorator
{
    public Armor(IHero hero) : base(hero)
    {
    }

    public override int Health => _hero.Health + 20;
    public override int Defense => _hero.Defense + 5;

    public override string GetDescription()
    {
        return $"{_hero.GetDescription()} with Armor (+20 Health, +5 Defense)";
    }
} 