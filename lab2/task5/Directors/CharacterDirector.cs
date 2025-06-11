using task.Builders;
using task.Models;

namespace task.Directors
{
    public class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder
                .SetHeight(180)
                .SetBuild("Атлетична")
                .SetHairColor("Біляве")
                .SetEyeColor("Сині")
                .SetClothing("Лицарські обладунки")
                .AddToInventory("Меч")
                .AddToInventory("Щит")
                .AddToInventory("Зілля здоров'я")
                .SetAlignment("Добрий")
                .AddDeed("Врятував село від дракона")
                .AddDeed("Захистив слабких")
                .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder
                .SetHeight(190)
                .SetBuild("Міцна")
                .SetHairColor("Чорне")
                .SetEyeColor("Червоні")
                .SetClothing("Темні обладунки")
                .AddToInventory("Темний меч")
                .AddToInventory("Посібник з магії для чайників")
                .AddToInventory("Зілля сили")
                .SetAlignment("Злий")
                .AddDeed("Викликав дракона в село")
                .AddDeed("Викрав принцесу")
                .Build();
        }
    }
} 