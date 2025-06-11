using task2.Interfaces;

namespace task2.Decorators;

public abstract class HeroDecorator : IHero
{
    protected readonly IHero _hero;

    protected HeroDecorator(IHero hero)
    {
        _hero = hero;
    }

    public virtual int Health => _hero.Health;
    public virtual int Attack => _hero.Attack;
    public virtual int Defense => _hero.Defense;
    public virtual string GetDescription() => _hero.GetDescription();
} 