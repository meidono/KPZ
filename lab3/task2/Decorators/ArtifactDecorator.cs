using task2.Interfaces;

namespace task2.Decorators;

public class ArtifactDecorator : HeroDecorator
{
    private readonly string _artifactName;
    private readonly int _attackBonus;
    private readonly int _defenseBonus;
    private readonly int _healthBonus;

    public ArtifactDecorator(IHero hero, string artifactName, int attackBonus, int defenseBonus, int healthBonus) : base(hero)
    {
        _artifactName = artifactName;
        _attackBonus = attackBonus;
        _defenseBonus = defenseBonus;
        _healthBonus = healthBonus;
    }

    public override int Health => _hero.Health + _healthBonus;
    public override int Attack => _hero.Attack + _attackBonus;
    public override int Defense => _hero.Defense + _defenseBonus;

    public override string GetDescription()
    {
        return $"{_hero.GetDescription()} with {_artifactName} (+{_attackBonus} Attack, +{_defenseBonus} Defense, +{_healthBonus} Health)";
    }
} 