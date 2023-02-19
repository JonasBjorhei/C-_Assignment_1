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

        public Warrior(string heroName)
        {
            name = heroName;
        }


        public override void equipWeapon() { }

        public override void equipArmor() { }




    }
}
