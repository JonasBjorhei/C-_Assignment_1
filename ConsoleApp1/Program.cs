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
            Name = "Diadelus"

        };
        Mage mageHero = new Mage()
        {
            Name = "Dumbledore"
        };

        Rogue rogueHero = new Rogue()
        {
            Name = "Bach stabb"
        };
        Ranger rangerHero = new Ranger()
        {
            Name = "Legolas"
        };


        Console.WriteLine("Hello, World!");
        Console.WriteLine(mageHero.Name);
        Console.WriteLine(mageHero.LevelAttributes.Strength);
        Console.WriteLine(mageHero.LevelAttributes.Dexterity);
        Console.WriteLine(mageHero.LevelAttributes.Intelligence);
        Console.WriteLine(mageHero.AttributeModifiers.IntelligenceModifier);
        mageHero.LevelUp();


        Console.WriteLine(mageHero.LevelAttributes.Strength);
        Console.WriteLine(mageHero.LevelAttributes.Dexterity);
        Console.WriteLine(mageHero.LevelAttributes.Intelligence);
        Console.WriteLine(mageHero.AttributeModifiers.IntelligenceModifier);
        Console.WriteLine(mageHero.ValidArmorTypes);
        Console.WriteLine(mageHero.ValidWeaponTypes);


    }
}
