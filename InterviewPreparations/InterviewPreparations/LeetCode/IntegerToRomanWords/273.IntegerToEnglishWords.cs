using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Convert a non-negative integer to its english words representation. 
    /// Given input is guaranteed to be less than 231 - 1.
    //  For example,
    //  123 -> "One Hundred Twenty Three"
    //  12345 -> "Twelve Thousand Three Hundred Forty Five"
    //  1234567 -> "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
    /// </summary>
    class IntegerToEnglishWords
    {
        public static string[] Less_Than_20 = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        public static string[] Tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public static string[] Thousand = { "", "Thousand", "Million", "Billion" };

        public static string ConvertIntegerToEnglishWords(int n)
        {
            string strNumber = string.Empty;
            int i = 0;

            // if number is Zero
            if (n == 0)
            {
                return "Zero";
            }

            while (n > 0)
            {
                if (n % 1000 != 0)
                {
                    strNumber = helper(n % 1000) + Thousand[i] + " " + strNumber;
                }

                n = n / 1000;
                i++;
            }

            return strNumber;
        }

        private static string helper(int n)
        {
            if (n == 0)
            {
                return "";
            }
            else if (n < 20)
            {
                return Less_Than_20[n];
            }
            else if (n < 100)
            {
                return Tens[n / 10] + " " + helper(n % 10);
            }
            else
            {
                return Less_Than_20[n / 100] + " Hundred " + helper(n % 100);
            }
        }
    }
}
