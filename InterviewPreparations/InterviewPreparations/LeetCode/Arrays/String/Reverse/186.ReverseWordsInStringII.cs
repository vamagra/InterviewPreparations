using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ReverseWordsInStringII
    {
        /// <summary>
        /// Given an input string, reverse the string word by word. A word is defined as a sequence of non-space characters.
        //  The input string does not contain leading or trailing spaces and the words are always separated by a single space.
        //  For example,
        //  Given s = "the sky is blue",
        //  return "blue is sky the".
        //  Could you do it in-place without allocating extra space?
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            char[] chArray = s.ToCharArray();

            // first reverse the whole string
            Reverse(chArray, 0, s.Length - 1);

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

            // Reverse the last word
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
