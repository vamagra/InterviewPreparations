using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MultiplyStrings
    {
        /// <summary>
        /// Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2.
        //  Note:
        //  The length of both num1 and num2 is < 110.
        //  Both num1 and num2 contains only digits 0-9.
        //  Both num1 and num2 does not contain any leading zero.
        //  You must not use any built-in BigInteger library or convert the inputs to integer directly.
        //  </summary>
        //  <param name="num1"></param>
        //  <param name="num2"></param>
        //  <returns></returns>

        public string multiplyStrings(string num1, string num2)
        {
            int l1 = num1.Length;
            int l2 = num2.Length;
            int l3 = l1 + l2;
            int[] num3 = new int[l3];
            int i = 0;

            for (i = l1 - 1; i >= 0; i--)
            {
                int carry = 0;
                int j = l2 - 1;
                for (; j >= 0; j--)
                {
                    int res = carry + num3[i + j + 1] +
                                (num1[i] - '0') * (num2[j] - '0');

                    num3[i + j + 1] = res % 10;
                    carry = res / 10;
                }

                num3[i + j + 1] = carry; // the carry need to carry to next position. since j is now -1, so nums3[i+j+1] means nums[i+j+1 - 1]. from backward it is the next position need the carry. SO ASSIGNED, NOT APPEND.
            }

            // below logic checks if we have zero in the output
            i = 0;
            for (; i < l3; i++)
            {
                if (num3[i] != 0)
                {
                    break;
                }
            }

            // if i will reach to length of the output then its means result contains all zero
            if (i == l3) return "0";

            StringBuilder sb = new StringBuilder();
            while (i < l3)
            {
                sb.Append(num3[i++]);
            }

            return sb.ToString();
        }

        public static string Multiply(string num1, string num2)
        {
            //get the length of both the strings
            int len1 = num1.Length;
            int len2 = num2.Length;

            //create a resulted array with length of s1 and s2
            int[] pos = new int[len1 + len2];

            //now loop through both the string from end
            for (int i = len1 - 1; i >= 0; i--)
            {
                for (int j = len2 - 1; j >= 0; j--)
                {
                    // multiply the i and j char of s1 and s2
                    int multiply = (num1[i] - '0') * (num2[j] - '0');

                    // now get the position of resulting Array pos1 and pos2 which will be i+j and i+j+1 
                    int pos1 = i + j;
                    int pos2 = i + j + 1;

                    // need to figure out why we are doing this
                    int sum = multiply + pos[pos1];

                    pos[pos1] += sum / 10;
                    pos[pos2] = sum % 10;
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (int item in pos)
            {
                if (!(sb.Length == 0 && item == 0))
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
    }
}
