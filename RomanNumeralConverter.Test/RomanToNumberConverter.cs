using NUnit.Framework;
using RomanNumeralConverter.App;

namespace RomanNumeralConverter.Test
{
    [TestFixture]
    class RomanToNumberConverter
    {
        [Test]
        public void Entering_the_Roman_Numeral_I_Results_in_number_1()
        {
            var romanNumeral = "I";
            var romanConverter = new RomanConverter();

            var result = romanConverter.Convert(romanNumeral);

            Assert.AreEqual(1, result);

        }

    }

 
}
