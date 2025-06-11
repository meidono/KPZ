using task2.Interfaces;
using task2.Decorators;

namespace task2.Items;

public class Sword : HeroDecorator
{
    public Sword(IHero hero) : base(hero)
    {
    }

    public override int Attack => _hero.Attack + 5;
    public override int Defense => _hero.Defense + 3;

    public override string GetDescription()
    {
        return $"{_hero.GetDescription()} with Sword (+5 Attack, +3 Defense)";
    }
} 