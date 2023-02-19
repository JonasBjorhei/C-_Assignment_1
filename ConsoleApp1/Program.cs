// See https://aka.ms/new-console-template for more information
using Assignment1.Heroes;
using Assignment1.Heroes.HeroTemplates;
using Assignment1.Items;
using System.Diagnostics;



internal class Assignment
{
    static void Main(string[] args)
    {
        Warrior warriorHero = new Warrior("Diadelus");
        Mage mageHero = new Mage("Dumbledore");
        Rogue rogueHero = new Rogue("Bach stabb");
        Ranger rangerHero = new Ranger("Legolas");

        mageHero.LevelUp();
        mageHero.LevelUp();
        mageHero.LevelUp();
        mageHero.LevelUp();
        mageHero.LevelUp();
        mageHero.LevelUp();
        mageHero.LevelUp();
        mageHero.LevelUp();

        Weapon wan = new Weapon("Frost wand", 5, Weapon.WeaponTypes.Wand);
        Armor robe = new Armor("Robe of destruction", 5, Armor.ArmorType.Cloth, HeroClass.Slot.Body);
        mageHero.EquipWeapon(wan);
        mageHero.EquipArmor(robe);

        Armor chestplate = new Armor("Chestplate of destruction", 5, Armor.ArmorType.Plate, HeroClass.Slot.Body);
        mageHero.EquipArmor(chestplate);

        mageHero.Display();
        rangerHero.Display();
        rogueHero.Display();
        warriorHero.Display();




    }
}
