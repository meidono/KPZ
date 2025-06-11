using task2.Interfaces;

namespace task2.Decorators;

public class ArmorDecorator : HeroDecorator
{
    private readonly string _armorName;
    private readonly int _defenseBonus;
    private readonly int _healthBonus;

    public ArmorDecorator(IHero hero, string armorName, int defenseBonus, int healthBonus) : base(hero)
    {
        _armorName = armorName;
        _defenseBonus = defenseBonus;
        _healthBonus = healthBonus;
    }

    public override int Health => _hero.Health + _healthBonus;
    public override int Defense => _hero.Defense + _defenseBonus;

    public override string GetDescription()
    {
        return $"{_hero.GetDescription()} wearing {_armorName} (+{_defenseBonus} Defense, +{_healthBonus} Health)";
    }
} 