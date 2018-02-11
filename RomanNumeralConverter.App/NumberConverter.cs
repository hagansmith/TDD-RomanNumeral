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
                {1, "I"},
                {5, "V"},
                {10, "X" },
                {50, "L" },
                {100, "C" },
                {500, "D" },
                {1000, "M" }
            };

            int remainder = number;

            while (remainder > 0)
            {
                if (romans.ContainsKey(remainder))
                {
                    result = romans[remainder] + result;
                    break;
                }
                else if (!romans.ContainsKey(number))
                {
                    int index = romans.Keys.ToList().BinarySearch(remainder);
                    string value = romans.ElementAt(+~index).Value;
                    int key = romans.ElementAt(+~index).Key;
                    remainder = key - remainder;
                    result += value;
                }
            }
            return result;
        }
    }
}
