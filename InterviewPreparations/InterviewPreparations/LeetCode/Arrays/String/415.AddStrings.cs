using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class AddStrings
    {
        /// <summary>
        /// Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.
        //  Note:
        //  The length of both num1 and num2 is < 5100.
        //  Both num1 and num2 contains only digits 0-9.
        //  Both num1 and num2 does not contain any leading zero.
        //  You must not use any built-in BigInteger library or convert the inputs to integer directly.
        //  </summary>
        //  <param name="s1"></param>
        //  <param name="s2"></param>
        //  <returns></returns>
        public static string AddTwoStringNumbers(string s1, string s2)
        {
            if(string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                return null;
            }

            int i = s1.Length - 1;
            int j = s2.Length - 1;

            StringBuilder result = new StringBuilder();
            int carry = 0;

            while (i >= 0 || j >= 0 || carry==1)
            {
                int digit1 = i >= 0 ? (s1[i--] - '0') : 0;
                int digit2 = j >= 0 ? (s2[j--] - '0') : 0;

                int sum = digit1 + digit2 + carry;

                result.Insert(0, sum % 10);

                carry = sum / 10;
            }

            return result.ToString();
        }
    }
}
