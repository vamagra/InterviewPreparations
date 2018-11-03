using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class RemoveCharFromOneStringToAnotherString
    {
        /// <summary>
        /// For the given input strings, remove the characters from the first string which are present in 
        //  second string. (with case sensitivity)
        //  Example
        //  a) Input string1 : computer
        //     Input string2 : cat
        //     Output : ompuer
        //     After removing characters from string2(c, a, t) from string1 we get ompuer
        //  b) Input string1 : occurrence
        //    Input string2 : car
        //    Output : ouene
        //  After removing characters from string2(c, a, r) from string1 we get ouene
        //  </summary>
        //  <param name="s1"></param>
        //  <param name="s2"></param>
        //  <returns></returns>
        public static string RemoveCharFromOneStringToAnotherStringMethod(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                return s1;
            }

            if (s2.Length > s1.Length)
            {
                return string.Empty;
            }

            int[] count = new int[256];
            int counter = 0;

            char[] chArray = s1.ToCharArray();

            for (int i = 0; i < s2.Length; i++)
            {
                count[s2[i]]++;
            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (count[s1[i]] <= 0)
                {
                    chArray[counter++] = s1[i];
                }
            }

            return new string(chArray, 0, counter);
        }
    }
}
