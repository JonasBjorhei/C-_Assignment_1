using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes.HeroTemplates
{
    internal class HeroAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int IntelligenceModifier { get; set; }


        public HeroAttributes(int strength, int dexterity, int intelligence, int stengthModifier, int dexterityModifier, int intelligenceModifier)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;

            StrengthModifier = stengthModifier;
            DexterityModifier = dexterityModifier;
            IntelligenceModifier = intelligenceModifier;
        }

        public void LevelUp(int level)
        {
            Strength = Strength * (level * StrengthModifier);
            Dexterity = Dexterity * (level * StrengthModifier);
            Intelligence = Intelligence * (level * StrengthModifier);
        }
    }
}
