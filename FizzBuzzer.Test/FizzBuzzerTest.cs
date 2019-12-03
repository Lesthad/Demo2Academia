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
            //var input = 1;
            //var expected = 1;

            ////Act
            var output = FizzBuzzer.GetValue(1);

            ////Assert
            //Assert.Equal(input.ToString(), output);

            Assert.Equal(1, output);
        }
    }
}
