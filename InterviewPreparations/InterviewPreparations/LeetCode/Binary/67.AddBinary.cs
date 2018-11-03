using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class AddBinary
    {
        /// <summary>
        /// Given two binary strings, return their sum (also a binary string).
        //  For example,
        //  a = "11"
        //  b = "1"
        //  Return "100".
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static string SumBinary(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2))
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(s1))
            {
                return s2;
            }

            if (string.IsNullOrEmpty(s2))
            {
                return s1;
            }

            StringBuilder sbResult = new StringBuilder();

            int sum = 0;
            int carry = 0;

            int len1 = s1.Length - 1;
            int len2 = s1.Length - 1;

            while (len1 >= 0 || len2 >= 0)
            {
                sum = carry;

                if (len1 >= 0)
                {
                    sum = sum + s1[len1--] - '0';
                }

                if (len2 >= 0)
                {
                    sum = sum + s2[len2--] - '0';
                }

                //append the result in string builder resulted variable
                sbResult.Append(sum % 2);

                carry = sum / 2;
            }

            if (carry != 0)
            {
                sbResult.Append(carry);
            }

            return Reverse(sbResult.ToString());
        }

        private static string Reverse(string s)
        {
            char[] chArray = s.ToCharArray();

            int start = 0;
            int end = s.Length - 1;

            while (start <= end)
            {
                char ch = chArray[start];
                chArray[start] = chArray[end];
                chArray[end] = ch;
                start++;
                end--;
            }

            return new string(chArray);
        }
    }
}
