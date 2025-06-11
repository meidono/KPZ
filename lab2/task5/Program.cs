using System;
using task.Builders;
using task.Directors;
using task.Models;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new CharacterDirector();
            var heroBuilder = new HeroBuilder();
            var enemyBuilder = new EnemyBuilder();

            var hero = director.CreateHero(heroBuilder);
            var enemy = director.CreateEnemy(enemyBuilder);

            Console.WriteLine("=== ГЕРОЙ ===");
            Console.WriteLine(hero);
            Console.WriteLine("\n=== ВОРОГ ===");
            Console.WriteLine(enemy);
        }
    }
} 