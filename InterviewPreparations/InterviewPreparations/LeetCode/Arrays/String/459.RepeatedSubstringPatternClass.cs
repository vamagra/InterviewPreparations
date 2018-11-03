using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RepeatedSubstringPatternClass
    {
        /// <summary>
        /// Given a non-empty string check if it can be constructed by taking a 
        //  substring of it and appending multiple copies of the substring together. 
        //  You may assume the given string consists of lowercase English letters only and 
        //  its length will not exceed 10000.
        //  Example 1:
        //  Input: "abab"
        //  Output: True
        //  Explanation: It's the substring "ab" twice.
        //  Example 2:
        //  Input: "aba"
        //  Output: False
        //  Example 3:
        //  Input: "abcabcabcabc"
        //  Output: True
        //  Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)
        // </summary>
        // <param name="s"></param>
        /// <returns></returns>
        public static bool IsRepeatedStringPattern(string s)
        {
            //  The length of the repeating substring must be a divisor of the length of the input string

            //  Search for all possible divisor of str.length, starting for length / 2

            //  If i is a divisor of length, repeat the substring from 0 to i the number of 

            //  times i is contained in s.length

            //  If the repeated substring is equals to the input str return true

            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            // Get the length of the string
            int len = s.Length;

            // run the loop from mid point of the string till starting
            for (int i = len / 2; i >= 1; i--)
            {
                // string can only be substring combination if the len is divisable by i, which would be even number
                if (len % i == 0)
                {
                    // now get the number, how many times a substring can be in string
                    int m = len / i;

                    // get the substring
                    string subS = s.Substring(0, i);

                    StringBuilder sb = new StringBuilder();

                    // make the string by addding subString m number of times
                    for (int j = 0; j < m; j++)
                    {
                        sb.Append(subS);
                    }

                    // check if the new string is equal to inputted string
                    if (sb.ToString().Equals(s)) return true;
                }
            }

            return false;
        }

        //public List<int> primesum(int A)
        //{
        //    List<int> result = new List<int>();
        //    if (A < 0)
        //    {
        //        return null;
        //    }

        //    if (A % 2 != 0)
        //    {
        //        return;
        //    }

        //    int counter = 2;

        //    int sum = 0;

        //    while (counter < A)
        //    {
        //        if (IsPrime(counter))
        //        {
        //            while (sum != A)
        //            {
        //                sum = sum + counter;
        //                result.Add(counter);
        //            }
        //        }

        //        counter++;
        //    }

        //    if (sum == A)
        //    {
        //        return result;
        //    }
        //    else
        //    {
        //        result = null;
        //    }

        //    return result;

        //}

        //public static bool IsPrime(int n)
        //{
        //    for (int i = 1; i < n / 2; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }
}
