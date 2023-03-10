using Assignment1.Heroes.HeroTemplates;
using Assignment1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes
{
    public class Warrior : HeroClass
    {
        public new enum ValidWeaponTypes
        {
            Sword,
            Hammer,
            Axe
        }

        public new enum ValidArmorTypes
        {
            Mail,
            Plate
        }

        public Warrior(string heroName)
        {
            name = heroName;
            Class = "Warrior";
            levelAttributes = new HeroAttributes(1, 1, 8, 1, 1, 5);
            startingArmorHead = new Armor("Beginner hood", 1, Armor.ArmorType.Mail, Slot.Head);
            startingArmorBody = new Armor("Beginner vest", 1, Armor.ArmorType.Mail, Slot.Body);
            startingArmorLegs = new Armor("Beginner pants", 1, Armor.ArmorType.Mail, Slot.Legs);
            startingWeapon = new Weapon("Beginner Sword", 1, Weapon.WeaponTypes.Sword);
            initializeStarterGear();
        }
        /// <summary>
        /// Checks if the weapon is a valid types. Equips it if it is.
        /// </summary>
        /// <param name="weapon"></param>
        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.requiredLevel <= level)
            {
                switch ((int)weapon.weaponType)
                {
                    case ((int)ValidWeaponTypes.Sword):
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                            break;
                    case ((int)ValidWeaponTypes.Hammer):
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                            break;
                    case ((int)ValidWeaponTypes.Axe):
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                            break;
                    default:
                        Console.WriteLine("The hero can't equip that weapon type ");
                        //throw InvalidWeaponType;
                        break;
                }
            }
            else Console.WriteLine("The hero is too low level to equip this");

            //throw LevelTooLowException;

        }
        /// <summary>
        /// Checks if the armor is a valid type. Equips it if it is.
        /// </summary>
        /// <param name="armor"></param>
        public override void EquipArmor(Armor armor)
        {
            if (armor.requiredLevel <= level)
            {
                switch ((int)armor.armorType)
                {
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
            else Console.WriteLine("The hero is too low level to equip this");
            //throw LevelTooLowException;
        }
    }
}
