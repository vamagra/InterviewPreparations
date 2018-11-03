using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.String
{

    class ShortestDistanceToCharacterInString
    {
        /// <summary>
        // Given a string S and a character C, return an array of integers representing the shortest distance from the character C in the string.
        // Example 1:
        // Input: S = "loveleetcode", C = 'e'
        // Output: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
        // Note:
        // S string length is in [1, 10000].
        // C is a single character, and guaranteed to be in string S.
        // All letters in S and C are lowercase.
        // </summary>
        // <param name="s"></param>
        // <param name="ch"></param>
        // <returns></returns>
        public static int[] ShortestDistance(string s, char ch)
        {
            if (string.IsNullOrEmpty(s) || ch == ' ')
            {
                return null;
            }

            Queue<int> queue = new Queue<int>();
            int[] result = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                {
                    queue.Enqueue(i);
                }
            }

            int left = -1;
            int right = queue.Dequeue();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                {
                    result[i] = 0;

                    //update the left and right
                    if (queue.Count > 0)
                    {
                        left = right;
                        right = queue.Dequeue();
                    }

                }

                if (left < 0)
                {
                    result[i] = Math.Abs(i - right);
                }
                else
                {
                    result[i] = Math.Min(Math.Abs(i - left), Math.Abs(i - right));
                }
            }

            return result;
        }
    }
}
