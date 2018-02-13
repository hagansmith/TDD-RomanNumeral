using System.Collections.Generic;



namespace RomanNumeralConverter.App
{
    public class NumberConverter
    {
        public string Convert(int number)
        {
            string result = "";

            Dictionary <int, string> romans = new Dictionary<int, string>
            {
                {1000, "M" },
                {900, "CM" },
                {500, "D" },
                {400, "CD" },
                {100, "C" },
                {90, "XC" },
                {50, "L" },
                {40, "XL" },
                {10, "X" },
                {9, "IX" },
                {5, "V"},
                {4, "IV"},
                { 1, "I"}
            };

            // Loop through the dictionary
            foreach (KeyValuePair<int, string> set in romans)
            {
                // while our given number is bigger than the current number key
                while (number >= set.Key )
                {
                    // append the current numeral to the result
                    result += set.Value;
                    // subtract the current key amount from the number
                    number -= set.Key;
                }
            }

            return result;
        }
    }
}
