using Assignment1.Heroes.HeroTemplates;
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
        public new ValidWeaponTypes validWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Staff & HeroClass.ValidWeaponTypes.Wand;

        public new ValidArmorTypes validArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Cloth;
 
        public Mage(string heroName)
        {
            name = heroName;
            Class = "Mage";

            levelAttributes= new HeroAttributes(1, 1, 8, 1, 1, 5);
            startingArmorHead = new Items.Armor("Beginner hat", 1, Items.Armor.ArmorType.Cloth, Slot.Head);
            startingArmorBody = new Items.Armor("Beginner robe", 1, Items.Armor.ArmorType.Cloth, Slot.Body);
            startingArmorLegs = new Items.Armor("Beginner pants", 1, Items.Armor.ArmorType.Cloth, Slot.Legs);
            startingWeapon = new Items.Weapon("Beginner staff", 1, Items.Weapon.WeaponTypes.Staff);
            initializeStarterGear();
            
        }

        public override void equipWeapon() { }

        public override void equipArmor() { }


    }
}
