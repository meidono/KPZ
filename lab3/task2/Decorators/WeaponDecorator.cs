using task2.Interfaces;

namespace task2.Decorators;

public class WeaponDecorator : HeroDecorator
{
    private readonly string _weaponName;
    private readonly int _attackBonus;

    public WeaponDecorator(IHero hero, string weaponName, int attackBonus) : base(hero)
    {
        _weaponName = weaponName;
        _attackBonus = attackBonus;
    }

    public override int Attack => _hero.Attack + _attackBonus;

    public override string GetDescription()
    {
        return $"{_hero.GetDescription()} with {_weaponName} (+{_attackBonus} Attack)";
    }
} 