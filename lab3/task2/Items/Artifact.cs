using task2.Interfaces;
using task2.Decorators;

namespace task2.Items;

public class Artifact : HeroDecorator
{
    public Artifact(IHero hero) : base(hero)
    {
    }

    public override int Health => _hero.Health + 10;
    public override int Attack => _hero.Attack + 7;
    public override int Defense => _hero.Defense + 7;

    public override string GetDescription()
    {
        return $"{_hero.GetDescription()} with Artifact (+10 Health, +7 Attack, +7 Defense)";
    }
}