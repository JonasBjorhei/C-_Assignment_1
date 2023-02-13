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

        public new enum mageWeapons
        {
            Wand,
            Staff
        }
        public HeroAttributes LevelAttributes { get; set; }
        public HeroAttributesModifiers AttributeModifiers { get; set; }
        public new ValidWeaponTypes ValidWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Staff & HeroClass.ValidWeaponTypes.Wand;
 
        public new ValidArmorTypes ValidArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Cloth;

        
    }
}
