using Assignment1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class RogueTests
    {
        [Fact]
        public void CreateRogue_ShouldReturnCorrectName()
        {
            //arrange 
            string expectedName = "Bach Stabb";
            //act 
            Rogue testRogue = new Rogue(expectedName);
            string realName = testRogue.name;
            //assert
            Assert.Equal(expectedName, realName);
        }
        [Fact]
        public void CreateRogue_ShouldReturnCorrectAttributes()
        {
            //arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            //act 
            Rogue testRogue = new Rogue("Bach Stabb");
            int[] realAttributes = new int[3] { testRogue.levelAttributes.Strength,
                                                testRogue.levelAttributes.Dexterity,
                                                testRogue.levelAttributes.Intelligence};
            //assert 
            Assert.Equal(expectedAttributes, realAttributes);
        }
        [Fact]
        public void LevelRogue_ShouldReturnCorrectLevelAfterLeveling()
        {
            //arrange
            int currentLevel = 1;
            int levelIncrement = 1;
            int expectedLevel = currentLevel + levelIncrement;
            //act
            Rogue testRogue = new Rogue("Bach Stabb");
            testRogue.LevelUp();
            int realLevel = testRogue.level;
            //assert
            Assert.Equal(expectedLevel, realLevel);
        }
        [Fact]
        public void LevelRogue_ShouldReturnCorrectAttributeAfterLeveling()
        {
            //arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            int[] expectedGainedAttributes = new int[3] { 1, 1, 5 };
            int[] expectedAttributesAfterLevelUp = new int[3] { expectedAttributes[0] + expectedGainedAttributes[0],
                                                                expectedAttributes[1] + expectedGainedAttributes[1],
                                                                expectedAttributes[2] + expectedGainedAttributes[2]};
            //act
            Rogue testRogue = new Rogue("Bach Stabb");
            testRogue.LevelUp();
            int[] RealAttributesAfterLevelUp = new int[3] {testRogue.levelAttributes.Strength,
                                                           testRogue.levelAttributes.Dexterity,
                                                           testRogue.levelAttributes.Intelligence};
            // assert
            Assert.Equal(expectedAttributesAfterLevelUp, RealAttributesAfterLevelUp);
        }
    }
}
