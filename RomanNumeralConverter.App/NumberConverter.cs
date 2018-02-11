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
            //while (remainder > 0)
            //{
                
                //if (romans.ContainsKey(remainder))
                //{
                //    if (result == "")
                //    {
                //        result = romans[remainder] + result;
                //    }
                //    else
                //    {
                //        result = result.Insert(result.Length - 1, romans[remainder]);
                //    }
                    
                //    break;
                //}
                //else if (romans.ContainsKey(remainder - 1))
                //{
                //    result = result + romans[remainder - 1];
                //    remainder = remainder - (remainder - 1);
                //    result = result + romans[remainder];
                //    remainder -= remainder; 
                //    continue;
                //}
                //else if (!romans.ContainsKey(number))
                //{
                //    if (remainder < 5 )
                //    {
                //        result += new String('I' , remainder);
                //        break;
                //    }
                //    else if (remainder < 10)
                //    {
                //        int index = romans.Keys.ToList().BinarySearch(remainder);
                //        string value = romans.ElementAt(+~index).Value;
                //        int key = romans.ElementAt(+~index).Key;
                //        remainder = key - remainder;
                //        result += value;
                //    }
                //    else if (remainder > 39)
                //    {
                //        int index = romans.Keys.ToList().BinarySearch(remainder);
                //        string value = romans.ElementAt(+~index).Value;
                //        int key = romans.ElementAt(+~index).Key;
                //        remainder = key - remainder;
                //        result += value;
                //    }
                //    else
                //    {
                //        int index = romans.Keys.ToList().BinarySearch(remainder);
                //        string value = romans.ElementAt(~index -1).Value;
                //        int key = romans.ElementAt(~index - 1).Key;
                //        remainder = remainder - key;
                //        result += value;
                //    }

                //}
            //}
            return result;
        }
    }
}
