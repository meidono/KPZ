using System.Collections.Generic;

namespace task.Models
{
    public class Character
    {
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; }
        public string Alignment { get; set; }
        public List<string> Deeds { get; set; }

        public Character()
        {
            Inventory = new List<string>();
            Deeds = new List<string>();
        }

        public override string ToString()
        {
            return $"Характеристики персонажа:\n" +
                   $"Зріст: {Height} см\n" +
                   $"Статура: {Build}\n" +
                   $"Колір волосся: {HairColor}\n" +
                   $"Колір очей: {EyeColor}\n" +
                   $"Одяг: {Clothing}\n" +
                   $"Інвентар: {string.Join(", ", Inventory)}\n" +
                   $"Світогляд: {Alignment}\n" +
                   $"Вчинки: {string.Join(", ", Deeds)}";
        }
    }
} 