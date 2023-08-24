using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(4, 6, 8, 18)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var testAdd = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = testAdd.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 7, 5)]
        [InlineData(2, 3, 1)]
        [InlineData(5, 5, 0)]
        public void SubtractTest(int num1, int num2, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var testSub = new Calculator();

            //Act

            var actual = testSub.Subtract(num1, num2);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 5, 15)]
        [InlineData(10, 5, 50)]
        [InlineData(2, 12, 24)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var testMultiply = new Calculator();

            //Act

            var actual = testMultiply.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 2, 10)]
        [InlineData(100, 4, 25)]
        [InlineData(8, 1, 8)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var testDivide = new Calculator();

            //Act

            var actual = testDivide.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

    }
}
