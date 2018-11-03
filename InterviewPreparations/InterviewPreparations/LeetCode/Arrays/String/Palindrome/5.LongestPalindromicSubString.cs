using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LongestPalindromicSubString
    {
        /*
         Time Complexity is On(n2)
         Space Complexity is O(1)
        */

        /// <summary>
        /// Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
        //  Example:
        //  Input: "babad"
        //  Output: "bab"
        //  Note: "aba" is also a valid answer.
        //  Example:
        //  Input: "cbbd"
        //  Output: "bb"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string LongestPalindrome(string str)
        {
            // Solution Explanation of this Algorithm
            // 1. Run the Loop from 2nd charater of the string till string length
            // 2. Expand the string from the center for Even string and get the max length ( from i-1, i)
            // 3. Expand the string from center for odd string and get the max length ( from i-1, i+1)
            // 4. you will get Max string palindrome after the loop

            int startLength = 0;
            int maxLenght = 1;

            int len = str.Length;

            int low = 0;
            int high = 0;

            for (int i = 1; i < len; i++)
            {
                // Find the longest even length palindrome with center points
                // as i-1 and i.

                low = i - 1;
                high = i;

                //check if the low and high charcter are within the 0 and max boundry. run the loop if both the low and high charcters macthes
                while (low >= 0 && high < len && str[low] == str[high])
                {
                    //update the max length
                    if (high - low + 1 > maxLenght)
                    {
                        startLength = low;
                        maxLenght = high - low + 1;
                    }

                    --low;
                    ++high;
                }


                // Find the longest odd length palindrome with center points
                // as i-1 and i+1.  

                low = i - 1;
                high = i + 1;

                while (low >= 0 && high < len && str[low] == str[high])
                {
                    if (high - low + 1 > maxLenght)
                    {
                        startLength = low;
                        maxLenght = high - low + 1;
                    }
                    --low;
                    ++high;
                }
            }

            return str.Substring(startLength, maxLenght);
        }
    }
}
