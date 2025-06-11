using task.Models;

namespace task.Builders
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetHeight(int height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            _character.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddToInventory(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public ICharacterBuilder SetAlignment(string alignment)
        {
            _character.Alignment = alignment;
            return this;
        }

        public ICharacterBuilder AddDeed(string deed)
        {
            _character.Deeds.Add(deed);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
} 