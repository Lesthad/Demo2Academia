using System;
using Xunit;

namespace FizzBuzzer.Test
{
    public class FizzBuzzerTest
    {
        [Fact]
        public void GivenValuesArePassed_WhenNoDivisibleBy3Or5_ThenPrintGivenNumber()
        {
            ////Arrange
            var input = 2;
            var expected = 2;

            ////Act
            var output = FizzBuzzer.GetValue(input);

            ////Assert
            //Assert.Equal(input.ToString(), output);

            Assert.Equal(expected, output);
        }
    }
}
