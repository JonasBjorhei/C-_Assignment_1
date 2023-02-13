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
        public HeroAttributes LevelAttributes { get; set; }
        public HeroAttributesModifiers AttributeModifiers { get; set; }

        public new ValidWeaponTypes ValidWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Axe & HeroClass.ValidWeaponTypes.Hammer & HeroClass.ValidWeaponTypes.Sword;

        public new ValidArmorTypes ValidArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Mail & HeroClass.ValidArmorTypes.Plate;
    }
}
