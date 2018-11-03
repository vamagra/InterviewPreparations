using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class StringCompression_CTCI
    {
        /// <summary>
        /// Given an array of characters, compress it in-place.
        //  The length after compression must always be smaller than or equal to the original array.
        //  Every element of the array should be a character(not int) of length 1.
        //  After you are done modifying the input array in-place, return the new length of the array.
        //  Follow up:
        //  Could you solve it using only O(1) extra space?
        // </summary>
        // <param name="chars"></param>
        /// <returns></returns>
        public static int Compression(char[] chars)
        {
            if (chars.Length < 1)
            {
                return 0;
            }

            int i = 0;
            int counter = 0;

            while (i < chars.Length)
            {
                int charCount = 1;

                char prevChar = chars[i];

                // increament i for next charachter
                i++;

                while (i < chars.Length && chars[i] == prevChar)
                {
                    charCount++;
                    i++;
                }
                    
                chars[counter++] = prevChar;

                if (charCount > 1)
                {
                    foreach (var item in charCount.ToString().ToCharArray())
                    {
                        chars[counter++] = item;
                    }
                }
            }

            return counter;
        }
    }
}
