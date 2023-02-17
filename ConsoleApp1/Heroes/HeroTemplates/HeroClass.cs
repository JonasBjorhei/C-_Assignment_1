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
        public string name { get; set; }
        public int level { get; set; } = 1;

        public string Class { get; set; }

        public HeroAttributes levelAttributes { get; set; }

        public object equipment { get; set; }

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

        public abstract void LevelUp();

        public void Equip () { }

        public abstract int Damage();

        public abstract int TotalAttributes();

        public abstract void Display();
    }
}
