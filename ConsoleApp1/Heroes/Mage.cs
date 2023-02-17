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
        public HeroAttributes levelAttributes { get; set; }
        public Mage(string heroName)
        {
            name = heroName;
            Class = "Mage";

         levelAttributes= new HeroAttributes(1, 1, 8, 1, 1, 5);

        startingWeapon = new Items.Weapon("Beginner staff", 1, Items.Weapon.WeaponTypes.Staff);
        }

        public override void LevelUp()
        {
            level++;
            levelAttributes.levelUpAttributes();
            Console.WriteLine(name + " leveled up to level " + level);
        }

        public override void equipWeapon() { }

        public override void equipArmor() { }

        public override int TotalAttributes()
        {
            return 0;
        }

        public override int Damage()
        {
            return 0;
        }

    }
}
