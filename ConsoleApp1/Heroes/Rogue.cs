using Assignment1.Heroes.HeroTemplates;
using Assignment1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes
{
    internal class Rogue : HeroClass
    {

        public string Class = "Rogue";
        public HeroAttributes levelAttributes { get; set; } = new HeroAttributes(2, 6, 1, 1, 4, 1);

        public new ValidWeaponTypes validWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Dagger & HeroClass.ValidWeaponTypes.Sword;

        public new ValidArmorTypes validArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Leather & HeroClass.ValidArmorTypes.Mail;

        public Rogue(string heroName)
        {
            name = heroName;
        }
        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.requiredLevel <= level)
            {
                switch ((int)weapon.weaponType)
                {
                    case ((int)ValidWeaponTypes.Staff):
                        if (validWeaponTypes == (ValidWeaponTypes)weapon.weaponType)
                        {
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                        }
                        else Console.WriteLine("The hero can't equip that weapon type ");
                        break;
                    case ((int)ValidWeaponTypes.Wand):
                        if (validWeaponTypes == (ValidWeaponTypes)weapon.weaponType)
                        {
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                        }
                        else Console.WriteLine("The hero can't equip that weapon type ");
                        break;
                    case ((int)ValidWeaponTypes.Bow):
                        if (validWeaponTypes == (ValidWeaponTypes)weapon.weaponType)
                        {
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                        }
                        else Console.WriteLine("The hero can't equip that weapon type ");
                        break;
                    case ((int)ValidWeaponTypes.Dagger):
                        if (validWeaponTypes == (ValidWeaponTypes)weapon.weaponType)
                        {
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                        }
                        else Console.WriteLine("The hero can't equip that weapon type ");
                        break;
                    case ((int)ValidWeaponTypes.Sword):
                        if (validWeaponTypes == (ValidWeaponTypes)weapon.weaponType)
                        {
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                        }
                        else Console.WriteLine("The hero can't equip that weapon type ");
                        break;
                    case ((int)ValidWeaponTypes.Hammer):
                        if (validWeaponTypes == (ValidWeaponTypes)weapon.weaponType)
                        {
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                        }
                        else Console.WriteLine("The hero can't equip that weapon type ");
                        break;
                    case ((int)ValidWeaponTypes.Axe):
                        if (validWeaponTypes == (ValidWeaponTypes)weapon.weaponType)
                        {
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);

                        }
                        else Console.WriteLine("The hero can't equip that weapon type ");
                        break;
                    default:
                        Console.WriteLine("Invalid weapon type");
                        //throw InvalidWeaponType;
                        break;

                }
            }
            else Console.WriteLine("The hero is too low level to equip this");

            //throw LevelTooLowException;

        }
        public override void EquipArmor(Armor armor)
        {
            if (armor.requiredLevel <= level)
            {
                switch ((int)armor.armorType)
                {
                    case (int)ValidArmorTypes.Cloth:
                        equipment[armor.slot] = armor;
                        Console.WriteLine("Equipped weapon " + armor.itemName);
                        break;
                    case (int)ValidArmorTypes.Leather:
                        equipment[armor.slot] = armor;
                        Console.WriteLine("Equipped weapon " + armor.itemName);
                        break;
                    case (int)ValidArmorTypes.Mail:
                        equipment[armor.slot] = armor;
                        Console.WriteLine("Equipped weapon " + armor.itemName);
                        break;
                    case (int)ValidArmorTypes.Plate:
                        equipment[armor.slot] = armor;
                        Console.WriteLine("Equipped weapon " + armor.itemName);
                        break;
                    default:
                        Console.WriteLine("Your class can not equip this armor type");
                        //throw InvalidWeaponType;
                        break;

                }
            }
            else throw LevelTooLowException;
        }
    }
}
