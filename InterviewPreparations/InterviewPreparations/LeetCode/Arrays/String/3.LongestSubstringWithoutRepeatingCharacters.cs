using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Given a string, find the length of the longest substring without repeating characters.
        //  Examples:
        //  Given "abcabcbb", the answer is "abc", which the length is 3.
        //  Given "bbbbb", the answer is "b", with the length of 1.
        //  Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// 
        public static int LongestSubstring(string s)
        {
            // Nice solution

            // Idea here is store the unique char in Hashtable with fast pointer
            // when there duplicate, fast will stop till unique chars and we will start removing the char 
            // from slow pointer till the duplicate char, means now slow will poit to the duplicate char
            // in string, when there is any unique char we will update the max count
            StringBuilder sb = new StringBuilder();

            int slow = 0, fast = 0, max = 0;
            HashSet<char> set = new HashSet<char>();

            while (fast < s.Length)
            {
                if (!set.Contains(s[fast]))
                {
                    set.Add(s[fast]);
                    fast++;
                    max = Math.Max(max, set.Count);
                }
                else
                {
                    set.Remove(s[slow++]);
                }
            }

            return max;
        }
        public static int LongestSubstringUniqueCharacters(string str)
        {
            int maxLength = 0;
            int curLength = 1;

            int[] visited = new int[256];

            int prevIndex = -1;

            //Initialize the visited array with -1
            for (int i = 0; i < 256; i++)
            {
                visited[i] = -1;
            }

            //if string is empty
            if(string.IsNullOrEmpty(str))
            {
                return -1;
            }

            //if string Length is 1
            if (str.Length == 1)
            {
                return curLength;
            }

            //convert the string in char array
            char[] charArray = str.ToCharArray();

            visited[charArray[0]] = 0;

            for (int i = 1; i <= charArray.Length - 1; i++)
            {
                prevIndex = visited[charArray[i]];

                //1. prevIndex=-1 will make sure that it is not the part of current NRCS

                //2. i - curLength > prevIndex will make sure that current char is not present present in already 
                //   processed substring
                if (prevIndex == -1 || i - curLength > prevIndex)
                {
                    curLength++;
                }
                else
                {
                    //update the max len
                    if (curLength > maxLength)
                    {
                        maxLength = curLength;
                    }

                    //change the current length of the NRCS

                    curLength = i - prevIndex;
                }

                //update the index of current char
                visited[charArray[i]] = i;
            }

            //update the max len
            if (curLength > maxLength)
            {
                maxLength = curLength;
            }

            return maxLength;
        }
        public static int LogenstSubstringUniqueCharWithTemplate(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            IDictionary<char, int> map = new Dictionary<char, int>();

            int begin = 0;
            int end = 0;
            int counter = 0;
            int resultedLen = 0;

            while (end < str.Length)
            {
                char chend = str[end];

                if(map.ContainsKey(chend))
                {
                    map[chend] = map[chend] + 1;
                }
                else
                {
                    map[chend] = 1;
                }

                if (map[chend] > 1)
                {
                    counter++;
                }

                end++;

                while (counter > 0)
                {
                    char chbegin = str[begin];

                    if (map[chbegin] > 1)
                    {
                        counter--;
                    }

                    if (map.ContainsKey(chbegin))
                    {
                        map[chbegin] = map[chbegin] - 1;
                    }

                    begin++;
                }

                resultedLen = Math.Max(resultedLen, end - begin);
            }

            return resultedLen;
        }
    }
}
