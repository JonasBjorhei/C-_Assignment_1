using Assignment1.Heroes.HeroTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes
{
    internal class Ranger : HeroClass
    {
        public string Class = "Ranger";
        public HeroAttributes levelAttributes { get; set; } = new HeroAttributes(1, 7, 1, 1, 5, 1);

        public new ValidWeaponTypes validWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Bow;

        public new ValidArmorTypes validArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Leather & HeroClass.ValidArmorTypes.Mail;

        public Ranger(string heroName)
        {
            name = heroName;
        }


        public override void equipWeapon() { }

        public override void equipArmor() { }

    }
}
