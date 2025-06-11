using task.Models;

namespace task.Builders
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(int height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder AddToInventory(string item);
        ICharacterBuilder SetAlignment(string alignment);
        ICharacterBuilder AddDeed(string deed);
        Character Build();
    }
} 