using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class FindAllAnagramsString
    {
        /// <summary>
        /// Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.
        //  Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.

        //The order of output does not matter.

        //Example 1:

        //Input:
        //s: "cbaebabacd" p: "abc"

        //Output:
        //[0, 6]

        //        Explanation:
        //The substring with start index = 0 is "cba", which is an anagram of "abc".
        //The substring with start index = 6 is "bac", which is an anagram of "abc".
        //Example 2:

        //Input:
        //s: "abab" p: "ab"

        //Output:
        //[0, 1, 2]

        //        Explanation:
        //The substring with start index = 0 is "ab", which is an anagram of "ab".
        //The substring with start index = 1 is "ba", which is an anagram of "ab".
        //The substring with start index = 2 is "ab", which is an anagram of "ab".
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        // 

        #region Explation Summary

        // In "438. Find All Anagrams in a String" problem, the counter means the number of keys contained in hash table for string p.
        // Because we want to find all t's anagrams in s, we want to check all substring that matches t's anagrams.
        // How can we check it? We can use a end pointer to go through s to check if an element in s matches an element in t.

        // Step 1 - For example, if t = 'abb', s = 'abbabb'.
        // Here we can create a hash table for string t :
        // Key (Value) : a(1), b(2). [Here, counter =2]

        // Step 2 - When iterating end, when it makes counter == 0, 
        // it means : substring 'abb' of s is an anagram of p. (This is because, we only decrement counter when the value of end is 0.

        // Step 3 - Now, the hash table is : Key (Value) : a(0), b(0). [Here, counter = 0, we increment end.]

        // Step 4 - Knowing this, we want to continue checking whether "bba"is an anagram of t. 
        // Here, we update the begin pointer to the second char of s. Before we do so, we have to check if there is some impact by pervious begin, 
        // which is the first char of s.Because we slid the window to s.substring(1,4) instead of s.substring(0,3), 
        // we want to get rid of the previous impact of first char of s.

        // Step 5 - We use map.get(tempc) > 0 to check whether or not s.charAt(begin) is matched with a key in hash table before.
        // If it is matched before, we should increase counter because it would be unmatched when we only want to check s.substring(0,3).

        // Step 6 - Why use map.get(tempc) > 0 ? Because in the outer while loop, for each char that is matched, 
        // its value must be larger than 0. (Because the char have to be in hash table.) In the outer 
        // while loop, we decrement the its value by 1, in the inner while loop, we increment its value by it.
        // So, after all, its value should be larger than 0.

        // Step 7 - Finally, we should check end - begin == t.length, because we want to make sure our matched substring have the same length with string t. 
        // The counter doesn't check the length for us, it only check whether all chars in string t can be found in s.substring.

        // It takes me a while to understand the solution.
        // I hope it helps : )

        #endregion
        public static IList<int> FindAllAnagramString(string s, string p)
        {
            IList<int> result = new List<int>();

            if (p.Length > s.Length)
            {
                return result;
            }

            IDictionary<char, int> dict = new Dictionary<char, int>();
            int begin = 0, end = 0;

            // Count the number of char in the target string (here p)
            for (int i = 0; i < p.Length; i++)
            {
                if (dict.ContainsKey(p[i]))
                {
                    dict[p[i]] = dict[p[i]] + 1;
                }
                else
                {
                    dict[p[i]] = 1;
                }
            }

            // number of counter is map.count
            int counter = dict.Count;

            while (end < s.Length)
            {
                char endCh = s[end];

                // check if char is present in the map table, if yes remove the char from table
                if (dict.ContainsKey(endCh))
                {
                    dict[endCh] = dict[endCh] - 1;

                    //if we have removed all occurance of that char from table, down the size of table to -1
                    if (dict[endCh] == 0)
                    {
                        counter--;
                    }
                }

                // move to the next char
                end++;

                while (counter == 0)
                {
                    char beginCh = s[begin];

                    if (dict.ContainsKey(beginCh))
                    {
                        dict[beginCh] = dict[beginCh] + 1;

                        if (dict[beginCh] > 0)
                        {
                            counter++;
                        }
                    }

                    // this is condition where we got the first index of anagram
                    if (end - begin == p.Length)
                    {
                        result.Add(begin);
                    }

                    begin++;
                }
            }

            return result;
        }
    }
}
