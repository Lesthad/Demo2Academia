using System;
using Xunit;

namespace FizzBuzzer.Test
{
    public class FizzBuzzerTest
    {
        [Fact]
        public void GivenValuesArePassed_WhenNotDivisibleBy3Or5_ThenPrintGivenNumber()
        {
            //Arrange
            var input = 2;
            var expected = 2;

            //Act
            var output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.Equal(expected.ToString(), output);
        }

        [Theory]
        [InlineData(3, 6, 9)]
        public void GivenValuesArePassed_WhenDivisibleBy3_ThenPrintFizz(params int[] inputs)
        {
            //Arrange
            //var input = 3;
            var expected = "Fizz";

            foreach (var input in inputs)
            {
                //Act
                var output = FizzBuzzer.GetValue(input);

                //Assert
                Assert.Equal(expected, output);
            }
        }

        [Theory]
        [InlineData(5, 10, 25, 100)]
        public void GivenValuesArePassed_WhenDivisibleBy5_ThenPrintBuzz(params int[] inputs)
        {
            //Arrange
            //var input = 3;
            var expected = "Buzz";

            foreach (var input in inputs)
            {
                //Act
                var output = FizzBuzzer.GetValue(input);

                //Assert
                Assert.Equal(expected, output);
            }
        }

        [Theory]
        [InlineData(15)]
        public void GivenValuesArePassed_WhenDivisibleBy3And5_ThenPrintFizzBuzz(params int[] inputs)
        {
            //Arrange
            //var input = 3;
            var expected = "FizzBuzz";

            foreach (var input in inputs)
            {
                //Act
                var output = FizzBuzzer.GetValue(input);

                //Assert
                Assert.Equal(expected, output);
            }
        }
    }
}
