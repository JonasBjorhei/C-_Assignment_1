using Assignment1.Heroes.HeroTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes
{
    internal class Rogue : HeroClass
    {
        public HeroAttributes LevelAttributes { get; set; }
        public HeroAttributesModifiers AttributeModifiers { get; set; }

        public new ValidWeaponTypes ValidWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Dagger & HeroClass.ValidWeaponTypes.Sword;

        public new ValidArmorTypes ValidArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Leather & HeroClass.ValidArmorTypes.Mail;
    }
}
