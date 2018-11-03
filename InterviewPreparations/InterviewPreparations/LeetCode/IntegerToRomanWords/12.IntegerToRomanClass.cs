using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Given an integer, convert it to a roman numeral.
    //  Input is guaranteed to be within the range from 1 to 3999.
    /// </summary>
    class IntegerToRomanClass
    {
        static int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        static string[] roman = { "M", "XM", "D", "XD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        public static string IntegerToRomanNumber(int num)
        {
            if (num < 1 && num > 3999)
            {
                return "";
            }

            StringBuilder sbResult = new StringBuilder();

            // Idea here is quite simple
            // check the number in values array
            // if it is greater than roman value then reduce it by roman value
            // append the roman char along side

            for (int i = 0; i < num; i++)
            {
                while (num >= values[i])
                {
                    // reduce the number roman number
                    num -= values[i];

                    // pick the roman numbe
                    sbResult.Append(roman[i]);
                }
            }

            return sbResult.ToString();
        }
    }
}
