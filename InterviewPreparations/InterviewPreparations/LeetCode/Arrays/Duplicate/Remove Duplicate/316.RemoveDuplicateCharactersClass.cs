using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays.Duplicate
{
    class RemoveDuplicateCharactersClass
    {
        /// <summary>
        /// Given a string which contains only lowercase letters, remove duplicate letters 
        //  so that every letter appear once and only once. You must make sure your result is the smallest in lexicographical order among all possible results.
        //  Example:
        //  Given "bcabc"
        //  Return "abc"
        //  Given "cbacdcbc"
        //  Return "acdb"
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string RemoveDuplicate(string s)
        {
            // step 1 - find out the last appeared position for each letter 
            // step 2 - get the position of min pos char (min value in dict)
            // step 3 - get the minchar from begin to minLast pos char
            // repeat the steps 2- 3 until we get char count = dict count
            // make sure to remove the minchar from dict after updating the result
            // if the last char is equal to minChar then update the lastPos

            /* find out the last appeared position for each letter;
              
             c - 7
             b - 6
             a - 2
             d - 4

             find out the smallest index from the map in step 1 (a - 2);

             the first letter in the final result must be the smallest letter from index 0 to index 2;

             repeat step 2 to 3 to find out remaining letters.

             the smallest letter from index 0 to index 2: a
             the smallest letter from index 3 to index 4: c
             the smallest letter from index 4 to index 4: d
             the smallest letter from index 5 to index 6: b
             so the result is "acdb"

             after one letter is determined in step 3, it need to be removed from the "last appeared position map", and the same letter should be ignored in the following steps
             in step 3, the beginning index of the search range should be the index of previous determined letter plus one*/

            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            IDictionary<char, int> dict = new Dictionary<char, int>();

            // get the min last appeared position of each letter 
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]] = i;
                }
                else
                {
                    dict.Add(s[i], i);
                }
            }

            char[] result = new char[dict.Count];
            int begin = 0; int end = minPosInDic(dict);

            for (int i = 0; i < s.Length; i++)
            {
                char minChar = (char)('z' + 1);
                for (int j = begin; j <= end; j++)
                {
                    if (dict.ContainsKey(s[j]) && s[j] < minChar)
                    {
                        // when minChar is found update the minChar and begin pointer
                        minChar = s[j];
                        begin = j + 1;
                    }
                }

                //  update the min Char in the result array
                result[i] = minChar;

                // breaking condition
                if (i == result.Length - 1)
                {
                    break;
                }

                dict.Remove(minChar);

                // update the end position with next min last pos char index
                if (s[end] == minChar)
                {
                    end = minPosInDic(dict);
                }
            }

            return new string(result);
        }

        // get the pos of min Pos char (min value in dict)
        private static int minPosInDic(IDictionary<char, int> dict)
        {
            if (dict.Count < 1 || dict == null)
            {
                return -1;
            }

            int minPosi = int.MaxValue;

            foreach (var key in dict.Keys)
            {
                minPosi = Math.Min(minPosi, dict[key]);
            }

            return minPosi;
        }
    }
}
