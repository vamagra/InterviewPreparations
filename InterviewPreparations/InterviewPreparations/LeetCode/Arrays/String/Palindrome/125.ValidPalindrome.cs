using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ValidPalindrome
    {
        /// <summary>
        ///     Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
        //      For example,
        //      "A man, a plan, a canal: Panama" is a palindrome.
        //        "race a car" is not a palindrome.
        //        Note:
        //      Have you consider that the string might be empty? This is a good question to ask during an interview.
        //        For the purpose of this problem, we define empty string as valid palindrome.
        // </summary>
        // <param name="str"></param>
        /// <returns></returns>
        public static bool CheckValidPalindromeString(string s) 
        {
        //    if (str.Trim().Length == 0)
        //    {
        //        return true;
        //    }

        //    int start = 0;
        //    int end = str.Length - 1;

        //    while (start <= end)
        //    {
        //        if (!IsAlphanumeric(str[start]))
        //        {
        //            start++;
        //        }
        //        else if (!IsAlphanumeric(str[end]))
        //        {
        //            end--;
        //        }
        //        else
        //        {
        //            if (str[start].ToString().ToLower() != str[end].ToString().ToLower())
        //            {
        //                return false;
        //            }

        //            start++;
        //            end--;
        //        }
        //    }

        //    return true;


            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int head = 0, tail = s.Length - 1;
            char cHead, cTail;
            while (head <= tail)
            {
                cHead = s[head];
                cTail = s[tail];
                if (!IsAlphanumeric(cHead))
                {
                    head++;
                }
                else if (!IsAlphanumeric(cTail))
                {
                    tail--;
                }
                else
                {
                    if (cHead.ToString().ToLower()!= cTail.ToString().ToLower())
                    {
                        return false;
                    }
                    head++;
                    tail--;
                }
            }

            return true;
        }

        public static bool IsAlphanumeric(char ch)
        {
            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == ' ')
            {
                return true;
            }

            return false;
        }
    }
}
