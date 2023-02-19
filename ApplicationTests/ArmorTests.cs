using Assignment1.Heroes.HeroTemplates;
using Assignment1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class ArmorTests
    {
        [Fact]
        public void CreateArmor_ShouldReturnCorrectName()
        {
            //arange
            Armor testArmor = new Armor("Beginner robe", 1, Armor.ArmorType.Cloth, HeroClass.Slot.Body);
            string expectedName = "Beginner robe";
            //act
            string realName = testArmor.itemName;
            //assert
            Assert.Equal(expectedName, realName);
        }
        [Fact]
        public void CreateArmor_ShouldReturnCorrectType()
        {
            //arrange
            Armor testArmor = new Armor("Beginner robe", 1, Armor.ArmorType.Cloth, HeroClass.Slot.Body);
            Armor.ArmorType expectedType = Armor.ArmorType.Cloth;
            //act 
            Armor.ArmorType realType = testArmor.armorType;
            //assert
            Assert.Equal(expectedType, realType);
        }
        [Fact]
        public void CreateArmor_ShouldReturnCorrectRequiredLevel()
        {
            //arrange
            Armor testArmor = new Armor("Beginner robe", 1, Armor.ArmorType.Cloth, HeroClass.Slot.Body);
            int expectedRequiredLevel = 1;
            //act
            int realRequiredLevel = testArmor.requiredLevel;
            //assert
            Assert.Equal(realRequiredLevel, expectedRequiredLevel);
        }
        [Fact]
        public void CreateArmor_ShouldReturnCorrectSlot()
        {
            //arrange
            Armor testArmor = new Armor("Beginner robe", 1, Armor.ArmorType.Cloth, HeroClass.Slot.Body);
            HeroClass.Slot expectedSlot = HeroClass.Slot.Body;
            //act
            HeroClass.Slot realSlot = testArmor.slot;
            //assert
            Assert.Equal(expectedSlot, realSlot);
        }
    }
}
