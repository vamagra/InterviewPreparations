using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.String.Important
{
    class TransformOneStringToAnother
    {
        /// <summary>
        /// Given two strings A and B, the task is to convert A to B if possible. 
        /// The only operation allowed is to put any character from A and insert it 
        /// at front. Find if it’s possible to convert the string. If yes, then output 
        /// minimum no. of operations required for transformation.
        //  Input:  A = "ABD", B = "BAD"
        //  Output: 1
        //  Explanation: Pick B and insert it at front.
        //  Input:  A = "EACBD", B = "EABCD"
        //  Output: 3
        //  Explanation: Pick B and insert at front, EACBD => BEACD
        //  Pick A and insert at front, BEACD => ABECD
        //  Pick E and insert at front, ABECD => EABCD
        //  </summary>
        //  <param name="s1"></param>
        //  <param name="s2"></param>
        //  <returns></returns>
        public static int GetTransformOneStringToAnother(string s1, string s2)
        {
            //  Below is complete algorithm.
            //  1) Find if A can be transformed to B or not by first creating a count array for all characters of A, then checking with B if B has same count for every character.
            //  2) Initialize result as 0.
            //  2) Start traversing from end of both strings.
            //  ……a) If current characters of A and B match, i.e., A[i] == B[j]
            //  ………then do i = i - 1 and j = j - 1
            //  ……b) If current characters don’t match, then search B[j] in remaining
            //  ………A.While searching, keep incrementing result as these characters
            //  ………must be moved ahead for A to B transformation.

            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                return -1;
            }

            int len1 = s1.Length;
            int len2 = s2.Length;

            if (len1 != len2)
            {
                return -1;
            }

            int[] count = new int[256];

            // Find if A can be transformed to B or not by first creating a count array for all characters of A, then checking with B if B has same count for every character.
            for (int k = 0; k < s1.Length; k++)
            {
                count[s1[k]]++;
            }

            for (int k = 0; k < s2.Length; k++)
            {
                if (count[s2[k]] > 0)
                {
                    count[s2[k]]--;
                }
                else
                {
                    return -1;
                }
            }
            // Till here

            int i = len1 - 1;
            int j = len2 - 1;

            int result = 0;

            while (i >= 0 && j >= 0)
            {
                if (s1[i] == s2[j])
                {
                    i--;
                    j--;
                }
                else
                {
                    while (s1[i] != s2[j])
                    {
                        j--;
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
