using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReverseVowelsOfString
    {
        /// <summary>
        /// Write a function that takes a string as input and reverse only the vowels of a string.
        //        Example 1:
        //Given s = "hello", return "holle".

        //Example 2:
        //Given s = "leetcode                                                                                                        ", return "leotcede".

        //Note:
        //The vowels does not include the letter "y".
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseVowel(string s)
        {
            char[] chArray = s.ToCharArray();

            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            int start = 0;
            int end = s.Length - 1;


            while (start <= end)
            {
                if (IsVolwel(chArray[start]) && IsVolwel(chArray[end]))
                {
                    char temp = chArray[start];
                    chArray[start] = chArray[end];
                    chArray[end] = temp;
                    start++;
                    end--;
                }
                else if(IsVolwel(chArray[start]))
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }

            return new string(chArray);
        }

        public static bool IsVolwel(char ch)
        {
            switch(ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    return true;
                default:
                    return false;
            }
        }
    }
}
