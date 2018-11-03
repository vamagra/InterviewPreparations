using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ReturnKthMostOccurringWord
    {
        public static string ReturnKthOccuringWord(string[] s, int k)
        {
            if (s.Length < 1)
            {
                return "";
            }

            IDictionary<string, int> dictMapping = new Dictionary<string, int>();

            foreach (string str in s)
            {
                if (dictMapping.Count == 0 && !dictMapping.ContainsKey(str))
                {
                    dictMapping.Add(str, 1);
                }
                else
                {
                    dictMapping[str] = dictMapping[str] + 1;

                    int value = dictMapping[str];

                    if (value == k)
                    {
                        return str;
                    }
                }
            }

            return string.Empty;
        }
    }
}
