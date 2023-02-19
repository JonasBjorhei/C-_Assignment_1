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
    public class Mage : HeroClass
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
            startingArmorHead = new Armor("Beginner hat", 1, Armor.ArmorType.Cloth, Slot.Head);
            startingArmorBody = new Armor("Beginner robe", 1, Armor.ArmorType.Cloth, Slot.Body);
            startingArmorLegs = new Armor("Beginner pants", 1, Armor.ArmorType.Cloth, Slot.Legs);
            startingWeapon = new Weapon("Beginner Staff", 1, Weapon.WeaponTypes.Staff);
            initializeStarterGear();
        }
        /// <summary>
        /// Checks if the weapon is a valid types. Equips it if it is.
        /// </summary>
        /// <param name="weapon"></param>
        public override void EquipWeapon(Weapon weapon)
        {
  //          try
  //          {
                if (weapon.requiredLevel <= level)
                {
  //                  try
  //                  {
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
                                Console.WriteLine("The hero can't equip that weapon type");
                                break;
                        }
            //                   }
            //                   catch (InvalidWeaponType ex)
            //                   {
            //                       Console.WriteLine("The hero can't equip that weapon type");
            //                       throw new InvalidWeaponType("The hero can't equip that weapon type");
            //                   }
                }
                else Console.WriteLine("The hero is too low level to equip this");
            //           }
            //           catch (LevelTooLowException ex)
            //           {
            //            Console.WriteLine("The hero is too low level to equip this");
            //          throw new LevelTooLowException("The hero is too low level to equip this", ex);    
            //           }
        }
        /// <summary>
        /// Checks if the armor is a valid type. Equips it if it is.
        /// </summary>
        /// <param name="armor"></param>
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
            else Console.WriteLine("The hero is too low level to equip this");
            //throw LevelTooLowException;
        }

    }
}
