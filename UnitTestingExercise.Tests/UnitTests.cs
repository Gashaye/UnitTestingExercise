using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10, 7, 1, 18)]
        [InlineData(100, 70,5, 175)]
        [InlineData(1, 1, 0, 2)]
        [InlineData(10, 10, 5, 25)]
        [InlineData(0, 4, 3, 7)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-5, -3, -2, -10)]
        [InlineData(-10, -3, -4, -17)]
        [InlineData(-10, -10, -5, -25)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            //Act
            //Assert
            UnitTestMethods unitTestAdd = new UnitTestMethods();
            var actual = unitTestAdd.Add(num1, num2, num3);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(10, 7, 3)]
        [InlineData(100, 75, 25)]
        [InlineData(1, 1, 0)]
        [InlineData(10, 15, -5)]
        [InlineData(0, 7, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, -10)]
        [InlineData(-10, -7, -3)]
        [InlineData(-10, -15, 5)]
        [InlineData(5, 1, 4)]
        [InlineData(7, 3, 4)]
        [InlineData(2, 1, 1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            UnitTestMethods unitTestSubstract = new UnitTestMethods();
            var actualSubstract = unitTestSubstract.Substract(minuend, subtrhend);
            Assert.Equal(actualSubstract, expected);
            //Arrange
            //Act
            //Assert
        }

        [Theory]
        [InlineData(2, 4, 8)]
        [InlineData(1, 3, 3)]
        [InlineData(8, 5, 40)]
        [InlineData(2, 3, 6)]
        public void Multiply(int num1, int num2, int expected)
        {
            UnitTestMethods unitTestMultiply = new UnitTestMethods();
            var actualMultiply = unitTestMultiply.Multiply(num1, num2);
            Assert.Equal(actualMultiply, expected);
        }

        [Theory]
        [InlineData(20, 2, 10)]
        [InlineData(15, 3, 5)]
        [InlineData(10, 1, 10)]
        public void Divide(int num1, int num2, int expected)
        {
            UnitTestMethods unitTestDivide = new UnitTestMethods();
            var actualDivide = unitTestDivide.Divide(num1, num2);
            Assert.Equal(actualDivide, expected);
        }

        [Fact]
        public void YourMethodName()
        {
            var testStarted = new UnitTestMethods();
            string actual = testStarted.YourMethodName();
            Assert.Equal("Test has started", actual);

            //Arrange
            //Act
            //Assert
        }

        [Fact]
        public void YourMethodName2()
        {
            var testCompleted = new UnitTestMethods();
            string actual = testCompleted.YourMethodName2();
            Assert.Equal("Test has been completed", actual);
            //Arrange
            //Act
            //Assert
        }
    }
}
