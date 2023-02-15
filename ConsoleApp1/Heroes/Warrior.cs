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
        public HeroAttributes LevelAttributes { get; set; } = new HeroAttributes(5, 2, 1);
        public HeroAttributesModifiers AttributeModifiers { get; set; } = new HeroAttributesModifiers(3, 2, 1);

        public new ValidWeaponTypes ValidWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Axe & HeroClass.ValidWeaponTypes.Hammer & HeroClass.ValidWeaponTypes.Sword;

        public new ValidArmorTypes ValidArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Mail & HeroClass.ValidArmorTypes.Plate;

        public void LevelUp()
        {
            Level = +1;
            LevelAttributes.Strength = LevelAttributes.Strength + AttributeModifiers.StrengthModifier;
            LevelAttributes.Dexterity = LevelAttributes.Dexterity + AttributeModifiers.DexterityModifier;
            LevelAttributes.Intelligence = LevelAttributes.Intelligence + AttributeModifiers.IntelligenceModifier;
        }
    }
}
