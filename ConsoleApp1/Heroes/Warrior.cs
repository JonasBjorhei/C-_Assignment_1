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
    }
}
