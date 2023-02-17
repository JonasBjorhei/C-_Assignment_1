using Assignment1.Heroes.HeroTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes
{
    internal class Warrior : HeroClass
    {

        public string Class = "Warrior";
        public HeroAttributes levelAttributes { get; set; } = new HeroAttributes(5, 2, 1, 3, 2, 1);
        public new ValidWeaponTypes validWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Axe & HeroClass.ValidWeaponTypes.Hammer & HeroClass.ValidWeaponTypes.Sword;

        public new ValidArmorTypes validArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Mail & HeroClass.ValidArmorTypes.Plate;

        public override void LevelUp()
        {
            level = +1;
            levelAttributes.levelUpAttributes();
            Console.WriteLine(name + " leveled up to level " + level);

        }

        public override int TotalAttributes()
        {
            return 0;
        }

        public override int Damage()
        {
            return 0;
        }

        public override void Display()
        {

        }
    }
}
