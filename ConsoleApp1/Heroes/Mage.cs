﻿using Assignment1.Heroes.HeroTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Heroes
{
    internal class Mage : HeroClass
    {

   
        public HeroAttributes LevelAttributes { get; set; } = new HeroAttributes(1, 1, 8);
        public HeroAttributesModifiers AttributeModifiers { get; set; } = new HeroAttributesModifiers(1, 1, 5);

        public new ValidWeaponTypes ValidWeaponTypes { get; set; } = HeroClass.ValidWeaponTypes.Staff & HeroClass.ValidWeaponTypes.Wand;
 
        public new ValidArmorTypes ValidArmorTypes { get; set; } = HeroClass.ValidArmorTypes.Cloth;

        public void LevelUp()
        {
            Level =+ 1;
            LevelAttributes.Strength = LevelAttributes.Strength + AttributeModifiers.StrengthModifier;
            LevelAttributes.Dexterity = LevelAttributes.Dexterity + AttributeModifiers.DexterityModifier;
            LevelAttributes.Intelligence = LevelAttributes.Intelligence + AttributeModifiers.IntelligenceModifier;
        }
    }
}
