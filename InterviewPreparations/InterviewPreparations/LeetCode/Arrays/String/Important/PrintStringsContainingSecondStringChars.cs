using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class PrintStringsContainingSecondStringChars
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strArray"></param>
        /// <param name="s"></param>
        public static void ContainingSecondStringsChars(string[] strArray, string s)
        {
            if (strArray != null && s.Length < 1)
            {
                return;
            }

            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            int[] count = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                if (count[s[i]] == 0)
                {
                    count[s[i]] = 1;
                }
            }

            foreach (string s1 in strArray)
            {
                char[] chArray = s1.ToCharArray();
                int len = 0;
                for (int j = 0; j < chArray.Length; j++)
                {
                    if (count[chArray[j]] > 0)
                    {
                        count[chArray[j]] = 0;
                        len++;

                        if (len == s.Length)
                        {
                            Console.WriteLine(new string(chArray));
                            break;
                        }
                    }
                }

                for (int i = 0; i < s.Length; i++)
                {
                    if (count[s[i]] == 0)
                    {
                        count[s[i]] = 1;
                    }
                }
            }
        }
    }
}
