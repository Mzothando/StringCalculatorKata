using FluentAssertions;
using NUnit.Framework;
using StringCalculatorKata.Library.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
        public void Add_Given_One_Number_Should_Return_That_Number(string number, int expected)
        {
            //---------------------------Arrange-------------------------------
            var stringCalculatorService = new StringCalculatorService();

            //---------------------------Act-----------------------------------
            var actual = stringCalculatorService.Add(number);

            //---------------------------Assert--------------------------------
            actual.Should().Be(expected);
        }

        [TestCase("1,2", 3)]
        [TestCase("34,101", 135)]
        [TestCase("23,23", 46)]
        public void Add_Given_Two_Numbers_Separated_By_Comma_Should_Return_Their_Sum(string numbers, int expected)
        {
            //---------------------------Arrange-------------------------------
            var stringCalculatorService = new StringCalculatorService();

            //---------------------------Act-----------------------------------
            var actual = stringCalculatorService.Add(numbers);

            //---------------------------Assert--------------------------------
            actual.Should().Be(expected);
        }

    }
}
