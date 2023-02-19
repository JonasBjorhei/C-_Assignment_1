using Assignment1.Heroes.HeroTemplates;
using Assignment1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes
{
    internal class Mage : HeroClass
    {

        public new enum ValidWeaponTypes
        {
            Staff,
            Wand
        }

        public new enum ValidArmorTypes
        {
            Cloth
        }
        public Mage(string heroName)
        {
            
            name = heroName;
            Class = "Mage";

            levelAttributes = new HeroAttributes(1, 1, 8, 1, 1, 5);
            startingArmorHead = new Items.Armor("Beginner hat", 1, Items.Armor.ArmorType.Cloth, Slot.Head);
            startingArmorBody = new Items.Armor("Beginner robe", 1, Items.Armor.ArmorType.Cloth, Slot.Body);
            startingArmorLegs = new Items.Armor("Beginner pants", 1, Items.Armor.ArmorType.Cloth, Slot.Legs);
            startingWeapon = new Items.Weapon("Beginner staff", 1, Items.Weapon.WeaponTypes.Staff);
            initializeStarterGear();
            
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.requiredLevel <= level)
            {
                switch ((int)weapon.weaponType)
                {
                    case ((int)ValidWeaponTypes.Staff):
                            equipment[weapon.slot] = weapon;
                            Console.WriteLine("Equipped weapon " + weapon.itemName);
                            break;
                    case ((int)ValidWeaponTypes.Wand):
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
        public override void EquipArmor(Armor armor)
        {
            if (armor.requiredLevel <= level)
            {
                switch ((int) armor.armorType)
                {
                    case (int) ValidArmorTypes.Cloth:
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
