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
        public HeroAttributes LevelAttributes { get; set; } = new HeroAttributes(2, 6, 1);
        public HeroAttributesModifiers AttributeModifiers { get; set; } = new HeroAttributesModifiers(1, 4, 1);

        public new ValidWeaponTypes ValidWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Dagger & HeroClass.ValidWeaponTypes.Sword;

        public new ValidArmorTypes ValidArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Leather & HeroClass.ValidArmorTypes.Mail;

        public void LevelUp()
        {
            Level = +1;
            LevelAttributes.Strength = LevelAttributes.Strength + AttributeModifiers.StrengthModifier;
            LevelAttributes.Dexterity = LevelAttributes.Dexterity + AttributeModifiers.DexterityModifier;
            LevelAttributes.Intelligence = LevelAttributes.Intelligence + AttributeModifiers.IntelligenceModifier;
        }
    }
}
