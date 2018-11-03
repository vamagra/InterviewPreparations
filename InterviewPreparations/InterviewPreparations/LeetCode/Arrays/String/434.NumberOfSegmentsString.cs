using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class NumberOfSegmentsString
    {
        /// <summary>
        /// Count the number of segments in a string, where a segment is defined to be a contiguous 
        //  sequence of non-space characters.
        //  Please note that the string does not contain any non-printable characters.
        //  Example:
        //  Input: "Hello, my name is John"
        //  Output: 5
        // </summary>
        // <param name="s"></param>
        /// <returns></returns>
        public static int CountSegmentInString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            int segment = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && (i == 0 || s[i - 1] == ' '))
                {
                    segment++;
                }
            }

            return segment;
        }
    }
}
