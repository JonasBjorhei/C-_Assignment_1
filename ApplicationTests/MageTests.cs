using Assignment1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class MageTests
    {
        [Fact]
        public void CreateMage_ShouldReturnCorrectName()
        {
            //arrange 
            string expectedName = "Dumbledore";
            //act 
            Mage testMage = new Mage(expectedName);
            string realName = testMage.name;
            //assert
            Assert.Equal(expectedName, realName);
        }
        [Fact]
        public void CreateMage_ShouldReturnCorrectAttributes()
        {
            //arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            //act 
            Mage testMage = new Mage("Dumbledore");
            int[] realAttributes = new int[3] { testMage.levelAttributes.Strength,
                                                testMage.levelAttributes.Dexterity,
                                                testMage.levelAttributes.Intelligence};
            //assert 
            Assert.Equal(expectedAttributes, realAttributes);
        }
        [Fact]
        public void LevelMage_ShouldReturnCorrectLevelAfterLeveling()
        {
            //arrange
            int currentLevel = 1;
            int levelIncrement = 1;
            int expectedLevel = currentLevel + levelIncrement;
            //act
            Mage testMage = new Mage("Dumbledore");
            testMage.LevelUp();
            int realLevel = testMage.level;
            //assert
            Assert.Equal(expectedLevel, realLevel);
        }
        [Fact]
        public void LevelMage_ShouldReturnCorrectAttributeAfterLeveling()
        {
            //arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            int[] expectedGainedAttributes = new int[3] { 1, 1, 5 };
            int[] expectedAttributesAfterLevelUp = new int[3] { expectedAttributes[0] + expectedGainedAttributes[0],
                                                                expectedAttributes[1] + expectedGainedAttributes[1],
                                                                expectedAttributes[2] + expectedGainedAttributes[2]};
            //act
            Mage testMage = new Mage("Dumbledore");
            testMage.LevelUp();
            int[] RealAttributesAfterLevelUp = new int[3] {testMage.levelAttributes.Strength,
                                                           testMage.levelAttributes.Dexterity,
                                                           testMage.levelAttributes.Intelligence};
            // assert
            Assert.Equal(expectedAttributesAfterLevelUp, RealAttributesAfterLevelUp);
        }
    }
}
