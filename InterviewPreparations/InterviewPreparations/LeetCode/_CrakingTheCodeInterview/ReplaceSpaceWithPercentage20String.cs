using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ReplaceSpaceWithPercentage20String
    {
        /// <summary>
        //  Write a method to replace all the spaces in a string with ‘%20’. You may assume that 
        //  the string has sufficient space at the end to hold the additional characters, and that you are 
        // given the “true” length of the string.
        //  Examples:
        //  Input : "Mr John Smith", 13
        //  Output : Mr%20John%20Smith
        //  Input : "Mr John Smith   ", 13
        //  Output : Mr%20John%20Smith
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string UrlifyString(string s, int len)
        {
            if (s == null || s.Length < 1)
            {
                return s;
            }

            // Count Spaces in string
            int spaceCount = 0;

            for (int i = 0; i < len; i++)
            {
                if (s[i] == ' ')
                {
                    spaceCount++;
                }
            }

            int totalLength = len + (spaceCount * 2);
            char[] newCharArray = new char[totalLength];

            int newIndex = totalLength - 1;
            
            //int counterK = s.Length;
            //int counterJ = counterK;

            //// Remove the trailing space
            //while (counterK >= 0 && chArray[counterK - 1] == ' ')
            //{
            //    counterK--;
            //}

            for (int i = len - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    newCharArray[newIndex--] = '0';
                    newCharArray[newIndex--] = '2';
                    newCharArray[newIndex--] = '%';
                }
                else
                {
                    newCharArray[newIndex--] = s[i];
                }
            }

            return new string(newCharArray);
        }
    }
}
