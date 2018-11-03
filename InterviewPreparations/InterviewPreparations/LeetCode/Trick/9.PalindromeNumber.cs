using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class PalindromeNumber
    {
        /// <summary>
        /// Determine whether an integer is a palindrome. Do this without extra space.
        //  click to show spoilers.
        //  Some hints:
        //  Could negative integers be palindromes? (ie, -1)
        //  If you are thinking of converting the integer to string, note the restriction of using extra space.
        //  You could also try reversing an integer.However, if you have solved the problem "Reverse Integer", you know that the reversed integer might overflow.How would you handle such case?
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            bool isResult = false;
            int reverseInt = 0;
            int num = x;
            int sign = 1;

            int prev_Integer = 0;

            //when number is 1 digit
            if (x > 0 && x < 10)
            {
                return true;
            }

            if (x < 0)
            {
                sign = -1;
            }

            while (x > 0)
            {
                int val = x % 10;
                reverseInt = reverseInt * 10 + val;

                //this condition is to prevent overflow of result
                if ((reverseInt - val) / 10 != prev_Integer)
                {
                    return false;
                }

                prev_Integer = reverseInt;
                x = x / 10;
            }

            if (num == reverseInt * sign)
            {
                isResult = true;
            }

            return isResult;
        }
    }
}
