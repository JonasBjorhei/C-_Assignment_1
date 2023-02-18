using Assignment1.Items;

namespace Assignment1.Heroes.HeroTemplates
{
    internal abstract class HeroClass
    {
        public string name { get; set; }
        public int level { get; set; } = 1;

        public string Class { get; set; }

        public HeroAttributes levelAttributes { get; set; }

        public Dictionary<Slot, Item> equipment { get; set; }

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

        public abstract void equipWeapon();

        public abstract void equipArmor();

        public abstract int Damage();

        public HeroAttributes TotalAttributes()
        {
            HeroAttributes totalAttributes = new HeroAttributes(0, 0, 0, 0, 0, 0);
            totalAttributes.Strength = totalAttributes.Strength + levelAttributes.Strength
                                      + equipment[Slot.Head].armorAttributes.Strength
                                      + equipment[Slot.Body].armorAttributes.Strength
                                      + equipment[Slot.Legs].armorAttributes.Strength;
            totalAttributes.Dexterity = totalAttributes.Dexterity + levelAttributes.Dexterity
                                     + equipment[Slot.Head].armorAttributes.Dexterity
                                     + equipment[Slot.Body].armorAttributes.Dexterity
                                     + equipment[Slot.Legs].armorAttributes.Dexterity;
            totalAttributes.Intelligence = totalAttributes.Intelligence + levelAttributes.Intelligence
                                     + equipment[Slot.Head].armorAttributes.Intelligence
                                     + equipment[Slot.Body].armorAttributes.Intelligence
                                     + equipment[Slot.Legs].armorAttributes.Intelligence;
            return totalAttributes;
        }

        public void Display()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: "+ Class);
            Console.WriteLine("Level ; "+ level);

            Console.WriteLine(name + " Strength is " + TotalAttributes().Strength);
            Console.WriteLine(name + " Dexterity is " + TotalAttributes().Dexterity);
            Console.WriteLine(name + " Intelligence is " + TotalAttributes().Intelligence);

            //Damage

/*            Console.WriteLine(equipment[Slot.Head].itemName + " Strength bonus is "  +equipment[Slot.Head].armorAttributes.Strength);
            Console.WriteLine(equipment[Slot.Head].itemName + " Dexterity bonus is " + equipment[Slot.Head].armorAttributes.Dexterity);
            Console.WriteLine(equipment[Slot.Head].itemName + " Intelligence bonus is " + equipment[Slot.Head].armorAttributes.Intelligence);

            Console.WriteLine(equipment[Slot.Body].itemName + " Strength bonus is " + equipment[Slot.Body].armorAttributes.Strength);
            Console.WriteLine(equipment[Slot.Body].itemName + " Dexterity bonus is " + equipment[Slot.Body].armorAttributes.Dexterity);
            Console.WriteLine(equipment[Slot.Body].itemName + " Intelligence bonus is " + equipment[Slot.Body].armorAttributes.Intelligence);

            Console.WriteLine(equipment[Slot.Legs].itemName + " Strength bonus is " + equipment[Slot.Legs].armorAttributes.Strength);
            Console.WriteLine(equipment[Slot.Legs].itemName + " Dexterity bonus is " + equipment[Slot.Legs].armorAttributes.Dexterity);
            Console.WriteLine(equipment[Slot.Legs].itemName + " Intelligence bonus is " + equipment[Slot.Legs].armorAttributes.Intelligence);

            Console.WriteLine(this.validArmorTypes);
            Console.WriteLine(this.validWeaponTypes);*/

            // Console.WriteLine(name + " Weapon is " + equipment[HeroClass.Slot.Weapon].slot);
        }

        public void initializeStarterGear()
        {
            equipment = new Dictionary<Slot, Item>();
            equipment.Add(Slot.Weapon, startingWeapon);
            equipment.Add(Slot.Head, startingArmorHead);
            equipment.Add(Slot.Body, startingArmorBody);
            equipment.Add(Slot.Legs, startingArmorLegs);

        }
    }
}
