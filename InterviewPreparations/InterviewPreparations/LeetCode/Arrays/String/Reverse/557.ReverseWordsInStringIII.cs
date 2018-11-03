using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReverseWordsInStringIII
    {
        /// <summary>
        /// Given a string, you need to reverse the order of characters in each word within a sentence while still 
        //  preserving whitespace and initial word order.
        //  Example 1:
        //  Input: "Let's take LeetCode contest"
        //  Output: "s'teL ekat edoCteeL tsetnoc"
        //  Note: In the string, each word is separated by single space and there will not be any extra space in the string.
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            char[] chArray = s.ToCharArray();

            int start = 0;
            int end = 0;
            for (int i = 0; i < chArray.Length; i++)
            {
                if (chArray[i] == ' ')
                {
                    end = i - 1;
                    Reverse(chArray, start, end);
                    start = i + 1;
                }
            }

            // Reverse the Last word
            Reverse(chArray, start, s.Length - 1);

            return new string(chArray);
        }

        public static void Reverse(char[] chArray, int start, int end)
        {
            while (start < end)
            {
                char tempCh = chArray[end];
                chArray[end] = chArray[start];
                chArray[start] = tempCh;

                start++;
                end--;
            }
        }            
    }
}
