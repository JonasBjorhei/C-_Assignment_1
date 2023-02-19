using Assignment1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class RangerTests
    {
        [Fact]
        public void CreateRanger_ShouldReturnCorrectName()
        {
            //arrange 
            string expectedName = "Legolas";
            //act 
            Ranger testRanger = new Ranger(expectedName);
            string realName = testRanger.name;
            //assert
            Assert.Equal(expectedName, realName);
        }
        [Fact]
        public void CreateRanger_ShouldReturnCorrectAttributes()
        {
            //arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            //act 
            Ranger testRanger = new Ranger("Legolas");
            int[] realAttributes = new int[3] { testRanger.levelAttributes.Strength,
                                                testRanger.levelAttributes.Dexterity,
                                                testRanger.levelAttributes.Intelligence};
            //assert 
            Assert.Equal(expectedAttributes, realAttributes);
        }
        [Fact]
        public void LevelRanger_ShouldReturnCorrectLevelAfterLeveling()
        {
            //arrange
            int currentLevel = 1;
            int levelIncrement = 1;
            int expectedLevel = currentLevel + levelIncrement;
            //act
            Ranger testRanger = new Ranger("Legolas");
            testRanger.LevelUp();
            int realLevel = testRanger.level;
            //assert
            Assert.Equal(expectedLevel, realLevel);
        }
        [Fact]
        public void LevelRanger_ShouldReturnCorrectAttributeAfterLeveling()
        {
            //arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            int[] expectedGainedAttributes = new int[3] { 1, 1, 5 };
            int[] expectedAttributesAfterLevelUp = new int[3] { expectedAttributes[0] + expectedGainedAttributes[0],
                                                                expectedAttributes[1] + expectedGainedAttributes[1],
                                                                expectedAttributes[2] + expectedGainedAttributes[2]};
            //act
            Ranger testRanger = new Ranger("Legolas");
            testRanger.LevelUp();
            int[] RealAttributesAfterLevelUp = new int[3] {testRanger.levelAttributes.Strength,
                                                           testRanger.levelAttributes.Dexterity,
                                                           testRanger.levelAttributes.Intelligence};
            // assert
            Assert.Equal(expectedAttributesAfterLevelUp, RealAttributesAfterLevelUp);
        }
    }
}
