using Assignment1.Heroes.HeroTemplates;
using Assignment1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class WeaponTests
    {
        [Fact]
        public void CreateWeapon_ShouldReturnCorrectName()
        {
            //arange
            Weapon testWeapon = new Weapon("Frost Wand", 3, Weapon.WeaponTypes.Wand);
            string expectedName = "Frost Wand";
            //act
            string realName = testWeapon.itemName;
            //assert
            Assert.Equal(expectedName, realName);
        }
        [Fact]
        public void CreateWeapon_ShouldReturnCorrectType()
        {
            //arrange
            Weapon testWeapon = new Weapon("Frost Wand", 3, Weapon.WeaponTypes.Wand);
            Weapon.WeaponTypes expectedType = Weapon.WeaponTypes.Wand;
            //act 
            Weapon.WeaponTypes realType = testWeapon.weaponType;
            //assert
            Assert.Equal(expectedType, realType);
        }
        [Fact]
        public void CreateWeapon_ShouldReturnCorrectRequiredLevel()
        {
            //arrange
            Weapon testWeapon = new Weapon("Frost Wand", 3, Weapon.WeaponTypes.Wand);
            int expectedRequiredLevel = 3;
            //act
            int realRequiredLevel = testWeapon.requiredLevel;
            //assert
            Assert.Equal(realRequiredLevel, expectedRequiredLevel);
        }
        [Fact]
        public void CreateWeapon_ShouldReturnCorrectSlot()
        {
            //arrange
            Weapon testWeapon = new Weapon("Frost Wand", 3, Weapon.WeaponTypes.Wand);
            HeroClass.Slot expectedSlot = HeroClass.Slot.Weapon;
            //act
            HeroClass.Slot realSlot = testWeapon.slot;
            //assert
            Assert.Equal(expectedSlot, realSlot);
        }
    }
}
