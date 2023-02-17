using Assignment1.Heroes.HeroTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Items
{
    internal class Weapon : Item
    {
        public int weaponDamage;
        public enum WeaponTypes
        {
            Staff,
            Wand,
            Bow,
            Dagger,
            Sword,
            Hammer,
            Axe
        };

        public WeaponTypes weaponType;

        

        public Weapon(string name, int reqLevel, WeaponTypes type)
        {
            itemName = name;
            requiredLevel = reqLevel;
            weaponType = type;
            slot = HeroClass.Slot.Weapon;
            weaponDamage = generateWeaponDamage();
        }

        private int generateWeaponDamage()
        {
            int damagemodifier = 4;
            int randomizedModifier = RandomNumberGenerator.GetInt32(damagemodifier) + 1;
            return (weaponDamage * requiredLevel) + randomizedModifier;
        }
    }
}
