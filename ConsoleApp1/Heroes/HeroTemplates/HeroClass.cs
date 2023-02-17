using Assignment1.Items;
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

        public HeroAttributes levelAttributes { get; }

        public Dictionary <Slot, Item> equipment { get; set; }

        public Exception LevelTooLowException;
        public Exception InvalidWeaponType;
        public Exception InvalidArmorType;

        public Weapon startingWeapon;
        public Armor startingArmorHead;
        public Armor startingArmorBody;
        public Armor startingArmorLegs;

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

        public ValidArmorTypes validArmorTypes;
        public ValidWeaponTypes validWeaponTypes;

        public enum Slot
        {
            Weapon,
            Head,
            Body,
            Legs
        }


        public abstract void LevelUp();

        public abstract void equipWeapon ();

        public abstract void equipArmor();

        public abstract int Damage();

        public abstract int TotalAttributes();

        public void Display()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(name);
            Console.WriteLine(Class);
            Console.WriteLine(name + " Strength is " + levelAttributes.Strength);
            //Console.WriteLine(name + " Dexterity is " + levelAttributes.Dexterity);
            //Console.WriteLine(name + " Intelligence is " + levelAttributes.Intelligence);
            //Console.WriteLine(name + " Int modifier is " + levelAttributes.IntelligenceModifier);
            LevelUp();


 /*           Console.WriteLine(name + " Strength is " + this.levelAttributes.Strength);
            Console.WriteLine(name + " Dexterity is " + this.levelAttributes.Dexterity);
            Console.WriteLine(name + " Intelligence is " + this.levelAttributes.Intelligence);
            Console.WriteLine(name + " Int modifier is " + this.levelAttributes.IntelligenceModifier);*/
            Console.WriteLine(this.validArmorTypes);
            Console.WriteLine(this.validWeaponTypes);

           // Console.WriteLine(name + " Weapon is " + equipment[HeroClass.Slot.Weapon].slot);
        }

        private void equipStarterGear()
        {
            equipment = new Dictionary<Slot, Item>();
            equipment.Add(Slot.Weapon, null);
            equipment.Add(Slot.Head, null);
            equipment.Add(Slot.Body, null);
            equipment.Add(Slot.Legs, null);

        }
    }
}
