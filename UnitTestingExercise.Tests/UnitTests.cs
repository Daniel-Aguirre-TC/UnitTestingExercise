using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 2, 2, 6)]
        [InlineData(4, 3, 9, 16)]
        [InlineData(5, 7, 6, 18)]
        [InlineData(8, 0, 9, 17)]
        [InlineData(9, 8, 6, 23)]
        [InlineData(1, 5, 3, 9)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Theory]
        [InlineData(10, 5, 5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(5, 5, 25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(10, 0, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsEven()
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.IsEven(2);

            //Assert

            Assert.True(actual);

        }

        [Fact]

        public void IsNegative()
        {
            //Arrange
            var obj = new UnitTestMethods();

            //Act
            var actual = obj.IsNegative(-30);

            //Assert
            Assert.True(actual);

        }
    }
}
