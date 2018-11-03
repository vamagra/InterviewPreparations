using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReverseString
    {
        public static string StringReverse(string s)
        {
            if (s.Length < 1)
            {
                return null;
            }

            int start = 0;
            int end = s.Length - 1;

            char[] chArray = s.ToCharArray();

            while (start <= end)
            {
                char temp = chArray[start];
                chArray[start] = chArray[end];
                chArray[end] = temp;
                start++;
                end--;
            }

            return new string(chArray);
        }

        public static string StringReverseUsingRecursion(string s)
        {
            // oft-repeated call, so reduce clutter with var
            int length = s.Length;

            if (length <= 1)
                return s;
            else
                return s.Substring(length - 1) + StringReverseUsingRecursion(s.Substring(0, length - 1));
        }
    }
}
