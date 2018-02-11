using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;


namespace RomanNumeralConverter.App
{
    public class NumberConverter
    {
        public string Convert(int number)
        {
            string result = "";
            int currentNumValue = number;

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

            //int remainder = number;
            foreach (KeyValuePair<int, string> set in romans)
            {
                while (number >= set.Key )
                {
                    result += set.Value;
                    number -= set.Key;
                }
            }

            return result;
        }
    }
}
