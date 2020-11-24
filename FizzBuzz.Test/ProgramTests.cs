using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Main;

namespace FizzBuzz.Test
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void If_input_is_evenly_divisible_by_three_Should_return_fizz()
        {
            // Arrange
            var input = 3;
            var expectedResult = "Fizz";

            // Act
            var result = Program.GetOutput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void If_input_is_evenly_divisible_by_five_Should_return_buzz()
        {
            // Arrange
            var input = 5;
            var expectedResult = "Buzz";

            // Act
            var result = Program.GetOutput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void If_input_is_evenly_divisible_by_both_three_and_five_Should_return_fizzbuzz()
        {
            // Arrange
            var input = 15;
            var expectedResult = "FizzBuzz";

            // Act
            var result = Program.GetOutput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void If_input_is_42_Should_return_the_meaning_of_life()
        {
            // Arrange
            var input = 42;
            var expectedResult = "Answer to the Ultimate Question of Life, the Universe, and Everything";

            // Act
            var result = Program.GetOutput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void If_input_is_not_divisible_by_three_or_five_and_is_not_fortytwo_Should_return_input_as_string()
        {
            // Arrange
            var input = 1;
            var expectedResult = input.ToString();

            // Act
            var result = Program.GetOutput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void If_user_input_is_not_an_int_Should_return_negative_one()
        {
            // Arrange
            var input = "Detta är fel";
            var expectedResult = -1;

            // Act
            var result = Program.ValidateInput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow("0")]
        [DataRow("666")]
        public void If_user_input_is_not_between_one_and_threehundred_Should_return_negative_one(string input)
        {
            // Arrange
            var expectedResult = -1;

            // Act
            var result = Program.ValidateInput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void If_user_input_is_between_one_and_threehundred()
        {
            // Arrange
            var input = "5";
            var expectedResult = int.Parse(input);

            // Act
            var result = Program.ValidateInput(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PrintMenu_Should_successfully_print_menu()
        {
            // Arrange
            var sw = new StringWriter();
            var expected = string.Format("Enter an integer between 1 and 300{0}", Environment.NewLine);
            Console.SetOut(sw);
            //Act
            Program.PrintMenu();
            //Assert
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void PrintResult_Should_successfully_print_result()
        {
            // Arrange
            var sw = new StringWriter();
            var input = 1;
            var expected = input.ToString() + Environment.NewLine;
                
            Console.SetOut(sw);
            //Act
            Program.PrintResult(input);
            //Assert
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void If_input_is_invalid_PrintResult_Should_print_error_message()
        {

            // Arrange
            var sw = new StringWriter();
            var input = -1;
            var expected = "Input must be an integer between 1 and 300" + Environment.NewLine;

            Console.SetOut(sw);
            //Act
            Program.PrintResult(input);
            //Assert
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void If_input_is_valid_should_return_input_as_int()
        {
            // Arrange
            var input = "5";
            var expected = int.Parse(input);

            var sr = new StringReader(input);
            Console.SetIn(sr);

            //Act
            var result = Program.GetUserInput();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
