using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Main;

namespace FizzBuzz.Test
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void If_Input_Is_Evenly_Divisible_By_Three_Should_Return_Fizz()
        {
            // Arrange
            var program = new Program();
            var input = 3;
            var expectedResult = "Fizz";

            // Act
            var result = program.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DividedByOnlyFiveIsBuzz()
        {
            // Arrange 

            // Act

            // Assert
        }

        [TestMethod]
        public void DividedByThreeAndFiveIsFizzBuzz()
        {
            // Arrange 

            // Act

            // Assert
        }

        [TestMethod]
        public void DividedByFortyTwoIsMeaningOfLife()
        {
            // Arrange 

            // Act

            // Assert
        }
    }
}
