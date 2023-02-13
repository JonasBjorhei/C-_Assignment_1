using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes.HeroTemplates
{
    internal abstract class HeroClass
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public HeroAttributes LevelAttributes { get; set; }

        public HeroAttributesModifiers AttributeModifiers { get; set; }


        public  object Equipment { get; set; }

        public enum ValidWeaponTypes 
        {
            Staff,
            Wand,
            Bow,
            Dagger,
            Sword,
            Hammer,
            Axe
        };

        public enum ValidArmorTypes
        { 
          Cloth,
          Leather,
          Mail,
          Plate
        };

    }
}
