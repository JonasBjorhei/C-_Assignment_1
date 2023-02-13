// See https://aka.ms/new-console-template for more information
using Assignment1.Heroes;
using Assignment1.Heroes.HeroTemplates;
using System.Diagnostics;



internal class Assignment
{
    static void Main(string[] args)
    {
        Warrior warriorHero = new Warrior()
        {
            Name = "Diadelus",
            Level = 1,
            LevelAttributes = new HeroAttributes(5, 2, 1, 3, 2, 1),

        };
        Mage mageHero = new Mage()
        {
            Name = "Dumbledore",
            Level = 1,
            LevelAttributes = new HeroAttributes(1, 1, 8, 1, 1, 5),
            
            
            

        };

        Rogue rogueHero = new Rogue()
        {
            Name = "Bach stabb",
            Level = 1,
            LevelAttributes = new HeroAttributes(2, 6, 1, 1, 4, 1),

        };
        Ranger rangerHero = new Ranger()
        {
            Name = "Legolas",
            Level = 1,
            LevelAttributes = new HeroAttributes(1, 7, 1, 1, 5, 1),
            
        };

        rangerHero.LevelAttributes.LevelUp(2);

        Console.WriteLine("Hello, World!");
        Console.WriteLine(rangerHero.LevelAttributes.Strength);
        Console.WriteLine(rangerHero.LevelAttributes.Dexterity);
        Console.WriteLine(rangerHero.LevelAttributes.Intelligence);
        Console.WriteLine(rangerHero.LevelAttributes.DexterityModifier);
        Console.WriteLine(mageHero.ValidArmorTypes);
        Console.WriteLine(mageHero.ValidWeaponTypes);


    }
}
