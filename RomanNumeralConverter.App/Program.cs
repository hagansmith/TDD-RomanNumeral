using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberInt = 0;

            Console.WriteLine("Enter a number to convert:");

            var number = Console.ReadLine();
            var numberConverter = new NumberConverter();
            
            Int32.TryParse(number, out numberInt);

            var result = numberConverter.Convert(numberInt);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
