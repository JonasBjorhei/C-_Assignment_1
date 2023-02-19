using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes.HeroTemplates
{
    public class HeroAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int IntelligenceModifier { get; set; }


        public HeroAttributes(int strength, int dexterity, int intelligence, int strengthModifier, int dexterityModifier, int intelligenceModifier)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;

            StrengthModifier = strengthModifier;
            DexterityModifier = strengthModifier;
            IntelligenceModifier = intelligenceModifier;
        }

        public void levelUpAttributes()
        {
            Strength = Strength + StrengthModifier;
            Dexterity = Dexterity + DexterityModifier;
            Intelligence= Intelligence + IntelligenceModifier;
        }

    }
}
