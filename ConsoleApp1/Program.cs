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
            name = "Diadelus"

        };
        Mage mageHero = new Mage()
        {
            name = "Dumbledore"
        };

        Rogue rogueHero = new Rogue()
        {
            name = "Bach stabb"
        };
        Ranger rangerHero = new Ranger()
        {
            name = "Legolas"
        };


        Console.WriteLine("Hello, World!");
        Console.WriteLine(mageHero.name);
        Console.WriteLine(mageHero.Class);
        Console.WriteLine(mageHero.name + " Strength is " + mageHero.levelAttributes.Strength);
        Console.WriteLine(mageHero.name + " Dexterity is " + mageHero.levelAttributes.Dexterity);
        Console.WriteLine(mageHero.name + " Intelligence is " + mageHero.levelAttributes.Intelligence);
        Console.WriteLine(mageHero.name + " Int modifier is " + mageHero.levelAttributes.IntelligenceModifier);
        mageHero.LevelUp();


        Console.WriteLine(mageHero.name + " Strength is " + mageHero.levelAttributes.Strength);
        Console.WriteLine(mageHero.name + " Dexterity is " + mageHero.levelAttributes.Dexterity);
        Console.WriteLine(mageHero.name + " Intelligence is " + mageHero.levelAttributes.Intelligence);
        Console.WriteLine(mageHero.name + " Int modifier is " + mageHero.levelAttributes.IntelligenceModifier);
        Console.WriteLine(mageHero.validArmorTypes);
        Console.WriteLine(mageHero.validWeaponTypes);


    }
}
