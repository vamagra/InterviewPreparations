using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    //  <summary>
    //  Given a string S and a string T, find the minimum window in S which will contain
    //  all the characters in T in complexity O(n).
    //  For example,
    //  S = "ADOBECODEBANC"
    //  T = "ABC"
    //  Minimum window is "BANC".
    //  Note:
    //  If there is no such window in S that covers all characters in T, return the empty string "".
    //  If there are multiple such windows, you are guaranteed that there will always be only one unique minimum window in S.
    //  </summary>
    class MinimumWindowSubstringClass
    {
        public static string MinimumWindowSubString(string s, string t)
        {
            string result = string.Empty;

            if (t.Length > s.Length)
            {
                return result;
            }

            // Step 1: Create Mapping Dictionary to count the t characters
            // create a hashmap to save the Characters of the target substring.

            IDictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < t.Length; i++)
            {
                char ch = t[i];
                if (map.ContainsKey(ch))
                {
                    map[ch] = map[ch] + 1;
                }
                else
                {
                    map[ch] = 1;
                }
            }

            // Step 2: maintain a counter to check whether match the target string.
            int counter = map.Count;

            // Step 3: Two Pointers: begin - left pointer of the window; end - right pointer of the window
            int begin = 0; int end = 0;

            //Step 4:
            int len = int.MaxValue;

            int head = 0;

            //Step 5: loop at the begining of the source string
            while (end < s.Length)
            {
                char chEnd = s[end]; //get a character

                if (map.ContainsKey(chEnd))
                {
                    map[chEnd] = map[chEnd] - 1; // minus one

                    if (map[chEnd] == 0)
                    {
                        counter--; //modify the counter here
                    }
                }

                end++;

                //// Step 6: increase begin pointer to make it invalid/valid again
                while (counter == 0)
                {
                    char chBegin = s[begin]; //***be careful here: choose the char at begin pointer, NOT the end pointer

                    if (map.ContainsKey(chBegin))
                    {
                        map[chBegin] = map[chBegin] + 1;

                        if (map[chBegin] > 0)
                        {
                            counter++;
                        }
                    }

                    if (end - begin < len)
                    {
                        len = end - begin;
                        head = begin;
                    }

                    begin++;
                }
            }

            if (len == int.MaxValue)
            {
                return result;
            }

            result = s.Substring(head, len);
            return result;
        }
    }
}
