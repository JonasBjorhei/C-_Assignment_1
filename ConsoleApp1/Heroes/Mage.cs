using Assignment1.Heroes.HeroTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes
{
    internal class Mage : HeroClass
    {
        public HeroAttributes LevelAttributes { get; set; }
        public HeroAttributesModifiers AttributeModifiers { get; set; }

        private static readonly (ValidWeaponTypes Wand, ValidWeaponTypes Staff) value = (HeroClass.ValidWeaponTypes.Wand, HeroClass.ValidWeaponTypes.Staff);
        public new ValidArmorTypes ValidArmorTypes = HeroClass.ValidArmorTypes.Cloth;

        
    }
}
