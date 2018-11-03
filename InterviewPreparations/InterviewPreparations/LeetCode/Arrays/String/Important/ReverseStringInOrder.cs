using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.String.Important
{
    class ReverseStringInOrder
    {
        /// <summary>
        /// Reverse string order like “Dowry is  a string” will convert as “string a is Dowry”
        //  Reverse complete string then reverse words
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

            Reverse(chArray, 0, chArray.Length);

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

            //Reverse(chArray, start, s.Length - 1);

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
