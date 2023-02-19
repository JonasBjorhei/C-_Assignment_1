using Assignment1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTests
{
    public class WarriorTests
    {
        [Fact]
        public void CreateWarrior_ShouldReturnCorrectName()
        {
            //arrange 
            string expectedName = "Diadelus";
            //act 
            Warrior testWarrior = new Warrior(expectedName);
            string realName = testWarrior.name;
            //assert
            Assert.Equal(expectedName, realName);
        }
        [Fact]
        public void CreateWarrior_ShouldReturnCorrectAttributes()
        {
            //arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            //act 
            Warrior testWarrior = new Warrior("Dumbledore");
            int[] realAttributes = new int[3] { testWarrior.levelAttributes.Strength,
                                                testWarrior.levelAttributes.Dexterity,
                                                testWarrior.levelAttributes.Intelligence};
            //assert 
            Assert.Equal(expectedAttributes, realAttributes);
        }
        [Fact]
        public void LevelWarrior_ShouldReturnCorrectLevelAfterLeveling()
        {
            //arrange
            int currentLevel = 1;
            int levelIncrement = 1;
            int expectedLevel = currentLevel + levelIncrement;
            //act
            Warrior testWarrior = new Warrior("Dumbledore");
            testWarrior.LevelUp();
            int realLevel = testWarrior.level;
            //assert
            Assert.Equal(expectedLevel, realLevel);
        }
        [Fact]
        public void LevelWarrior_ShouldReturnCorrectAttributeAfterLeveling()
        {
            //arrange
            int[] expectedAttributes = new int[3] { 1, 1, 8 };
            int[] expectedGainedAttributes = new int[3] { 1, 1, 5 };
            int[] expectedAttributesAfterLevelUp = new int[3] { expectedAttributes[0] + expectedGainedAttributes[0],
                                                                expectedAttributes[1] + expectedGainedAttributes[1],
                                                                expectedAttributes[2] + expectedGainedAttributes[2]};
            //act
            Warrior testWarrior = new Warrior("Dumbledore");
            testWarrior.LevelUp();
            int[] RealAttributesAfterLevelUp = new int[3] {testWarrior.levelAttributes.Strength,
                                                           testWarrior.levelAttributes.Dexterity,
                                                           testWarrior.levelAttributes.Intelligence};
            // assert
            Assert.Equal(expectedAttributesAfterLevelUp, RealAttributesAfterLevelUp);
        }
    }
}
