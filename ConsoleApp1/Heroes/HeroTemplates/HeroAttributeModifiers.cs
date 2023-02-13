using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes.HeroTemplates
{
    internal class HeroAttributesModifiers
    {
        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int IntelligenceModifier { get; set; }
        public HeroAttributesModifiers(int stengthModifier, int dexterityModifier, int intelligenceModifier)
        {
            StrengthModifier = stengthModifier;
            DexterityModifier = dexterityModifier;
            IntelligenceModifier = intelligenceModifier;
        }
    }
}
