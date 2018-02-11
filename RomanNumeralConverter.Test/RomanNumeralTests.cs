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

        [Test]
        public void Entering_the_number_68_results_in_roman_numeral_LXVIII()
        {
            // Arrange
            var number = 68;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("LXVIII", result);
        }

        [Test]
        public void Entering_the_number_83_results_in_roman_numeral_LXXXIII()
        {
            // Arrange
            var number = 83;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("LXXXIII", result);
        }

        [Test]
        public void Entering_the_number_97_results_in_roman_numeral_XCVII()
        {
            // Arrange
            var number = 97;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("XCVII", result);
        }

        [Test]
        public void Entering_the_number_99_results_in_roman_numeral_XCIX()
        {
            // Arrange
            var number = 99;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("XCIX", result);
        }

        [Test]
        public void Entering_the_number_500_results_in_roman_numeral_D()
        {
            // Arrange
            var number = 500;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("D", result);
        }

        [Test]
        public void Entering_the_number_501_results_in_roman_numeral_DI()
        {
            // Arrange
            var number = 501;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("DI", result);
        }

        [Test]
        public void Entering_the_number_649_results_in_roman_numeral_DCXLIX()
        {
            // Arrange
            var number = 649;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("DCXLIX", result);
        }

        [Test]
        public void Entering_the_number_798_results_in_roman_numeral_DCCXCVIII()
        {
            // Arrange
            var number = 798;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("DCCXCVIII", result);
        }

        [Test]
        public void Entering_the_number_891_results_in_roman_numeral_DCCCXCI()
        {
            // Arrange
            var number = 891;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("DCCCXCI", result);
        }

        [Test]
        public void Entering_the_number_1000_results_in_roman_numeral_M()
        {
            // Arrange
            var number = 1000;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("M", result);
        }

        [Test]
        public void Entering_the_number_1004_results_in_roman_numeral_MIV()
        {
            // Arrange
            var number = 1004;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("MIV", result);
        }

        [Test]
        public void Entering_the_number_1006_results_in_roman_numeral_MVI()
        {
            // Arrange
            var number = 1006;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("MVI", result);
        }

        [Test]
        public void Entering_the_number_1023_results_in_roman_numeral_MXXIII()
        {
            // Arrange
            var number = 1023;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("MXXIII", result);
        }

        [Test]
        public void Entering_the_number_2014_results_in_roman_numeral_MMXIV()
        {
            // Arrange
            var number = 2014;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("MMXIV", result);
        }

        [Test]
        public void Entering_the_number_3999_results_in_roman_numeral_MMMCMXCIX()
        {
            // Arrange
            var number = 3999;
            var numberConverter = new NumberConverter();
            // Act
            var result = numberConverter.Convert(number);
            // Assert
            Assert.AreEqual("MMMCMXCIX", result);
        }
    }
}
