using Assignment1.Heroes.HeroTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Items
{
    internal class Armor : Item
    {
        public enum ArmorType
        {
            Cloth,
            Leather,
            Mail,
            Plate
        };

        public ArmorType armorType;

        public HeroAttributes armorAttributes;
        public int[] armorModifiers = { 0, 0, 0 };

        public Armor (string name, int reqLevel, ArmorType type, HeroClass.Slot itemSlot)
        {
            itemName = name;
            requiredLevel = reqLevel;
            armorType = type;
            slot= itemSlot;
            armorAttributes = new HeroAttributes(
                calculateArmorAttribute(), calculateArmorAttribute(), calculateArmorAttribute(),
                armorModifiers[0], armorModifiers[1], armorModifiers[2]
                );
        }
        private int calculateArmorAttribute()
        {
            int maxAttribute = 10;
            int randomizedModifier = RandomNumberGenerator.GetInt32(maxAttribute);
            return requiredLevel + randomizedModifier;
        }
    }
}
