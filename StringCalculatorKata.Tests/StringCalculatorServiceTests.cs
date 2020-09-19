using FluentAssertions;
using NUnit.Framework;
using StringCalculatorKata.Library.Services;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    class StringCalculatorServiceTests
    {
        [Test]
        public void Add_Given_Empty_String_Should_Return_Zero()
        {
            //---------------------------Arrange-------------------------------
            var stringNumber = "";
            var stringCalculatorService = new StringCalculatorService();

            //---------------------------Act-----------------------------------
            var actual = stringCalculatorService.Add(stringNumber);

            //---------------------------Assert--------------------------------
            actual.Should().Be(0);
        }

        [TestCase("1", 1)]
        [TestCase("10", 10)]
        [TestCase("100", 100)]
        public void Add_Given_One_Number_Should_Return_That_Number(string number, int results)
        {
            //---------------------------Arrange-------------------------------
            var stringCalculatorService = new StringCalculatorService();

            //---------------------------Act-----------------------------------
            var actual = stringCalculatorService.Add(number);

            //---------------------------Assert--------------------------------
            actual.Should().Be(results);
        }

        [TestCase("1,2", 3)]
        [TestCase("34,101", 135)]
        [TestCase("23,23", 46)]
        public void Add_Given_Two_Numbers_Separated_By_Comma_Should_Return_Their_Sum(string numbers, int results)
        {
            //---------------------------Arrange-------------------------------
            var stringCalculatorService = new StringCalculatorService();

            //---------------------------Act-----------------------------------
            var actual = stringCalculatorService.Add(numbers);

            //---------------------------Assert--------------------------------
            actual.Should().Be(results);
        }

        [TestCase("1,4,5", 10)]
        [TestCase("10,40,50,15", 115)]
        [TestCase("101,100,500,150", 851)]
        public void Add_Given_Numbers_Separated_By_Comma_Should_Return_Their_Sum(string numbers, int results)
        {
            //---------------------------Arrange-------------------------------
            var stringCalculatorService = new StringCalculatorService();

            //---------------------------Act-----------------------------------
            var actual = stringCalculatorService.Add(numbers);

            //---------------------------Assert--------------------------------
            actual.Should().Be(results);

        }

        [TestCase("1\n2\n3", 6)]
        [TestCase("10\n13\n17", 40)]
        [TestCase("203\n150\n110", 463)]
        public void Add_Given_Numbers_Separated_By_New_Line_Should_Return_Their_Sum(string numbers, int results)
        {
            //---------------------------Arrange-------------------------------
            var stringCalculatorService = new StringCalculatorService();

            //---------------------------Act-----------------------------------
            var actual = stringCalculatorService.Add(numbers);

            //---------------------------Assert--------------------------------
            actual.Should().Be(results);

        }

        [TestCase("1\n2,3", 6)]
        [TestCase("10,13\n17, 10", 50)]
        [TestCase("203\n150,110\n17,200", 680)]
        public void Add_Given_Numbers_Separated_By_Both_New_Line_And_Comma_Should_Return_Their_Sum(string numbers, int results)
        {
            //---------------------------Arrange-------------------------------
            var stringCalculatorService = new StringCalculatorService();

            //---------------------------Act-----------------------------------
            var actual = stringCalculatorService.Add(numbers);

            //---------------------------Assert--------------------------------
            actual.Should().Be(results);

        }
    }
}
