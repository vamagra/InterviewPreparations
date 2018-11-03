using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class GroupAnagrams
    {
        /// <summary>
        //  Given an array of strings, group anagrams together.
        //  For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
        //  Return:
        //  [
        //      ["ate", "eat","tea"],
        //      ["nat","tan"],
        //      ["bat"]
        //  ]
        //  Note: All inputs will be in lower-case.
        //  </summary>
        //  <param name="strs"></param>
        /// <returns></returns>
        public static IList<IList<string>> GroupValidAnagramsStrings(string[] strs)
        {
            IList<IList<string>> resultedString = new List<IList<string>>();

            if (strs.Length == 0)
            {
                return null;
            }

            if (strs.Length == 1)
            {
                List<string> temp = new List<string>();
                temp.Add(strs[0]);

                resultedString.Add(temp);

                return resultedString;
            }

            IDictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (string s in strs)
            {
                char[] ch = s.ToCharArray();

                //sort the string array
                Array.Sort(ch);

                if (dict.ContainsKey(new string(ch)))
                {
                    List<string> group = dict[new string(ch)];
                    group.Add(s);

                    dict[new string(ch)] = group;
                }
                else
                {
                    List<string> newGroup = new List<string>();
                    newGroup.Add(s);

                    dict.Add(new string(ch), newGroup);
                }
            }

            return new List<IList<string>>(dict.Values);
        }
    }
}
