using NUnit.Framework;
using RomanNumeralConverter.App;

namespace RomanNumeralConverter.Test
{
    [TestFixture]
    public class RomanNumeralTests
    {
        [Test]
        public void Entering_the_number_1_results_in_roman_numeral_I()
        {
            // Arrange
            var number = 1;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("I", result);
        }
    }
}
