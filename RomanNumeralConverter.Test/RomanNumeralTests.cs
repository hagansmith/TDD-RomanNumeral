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

        [Test]
        public void Entering_the_number_5_results_in_roman_numeral_V()
        {
            // Arrange
            var number = 5;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("V", result);
        }

        [Test]
        public void Entering_the_number_9_results_in_roman_numeral_IX()
        {
            // Arrange
            var number = 9;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("IX", result);
        }

        [Test]
        public void Entering_the_number_12_results_in_roman_numeral_XII()
        {
            // Arrange
            var number = 12;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("XII", result);
        }

        [Test]
        public void Entering_the_number_16_results_in_roman_numeral_XVI()
        {
            // Arrange
            var number = 16;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("XVI", result);
        }
        [Test]
        public void Entering_the_number_29_results_in_roman_numeral_XXIX()
        {
            // Arrange
            var number = 29;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("XXIX", result);
        }

        [Test]
        public void Entering_the_number_44_results_in_roman_numeral_XLIV()
        {
            // Arrange
            var number = 44;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("XLIV", result);
        }

        [Test]
        public void Entering_the_number_45_results_in_roman_numeral_XLV()
        {
            // Arrange
            var number = 45;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("XLV", result);
        }
    }
}
