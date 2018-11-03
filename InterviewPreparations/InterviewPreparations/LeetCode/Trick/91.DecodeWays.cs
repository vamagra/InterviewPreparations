using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class DecodeWays
    {
        /// <summary>
        /// A message containing letters from A-Z is being encoded to numbers using the following mapping:
        //  'A' -> 1
        //  'B' -> 2
        //  ...
        //  'Z' -> 26
        //  Given an encoded message containing digits, determine the total number of ways to decode it.
        //  For example,
        //  Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).
        //  The number of ways decoding "12" is 2.
        //  </summary>
        //  <param name="s"></param>
        /// <returns></returns>
        public static int NoOfDecodeWays(string s)
        {
            int n = s.Length;

            if (n == 0)
            {
                return 0;
            }

            //create dp array n+1 length
            int[] dp = new int[n + 1];

            //when the string is empty, there is only one answer
            dp[n] = 1;

            //when there is only one character in the string, if this character is not 
            //0, there will be an answer, or there will be no answer
            dp[n - 1] = s[n - 1] != '0' ? 1 : 0;

            //DP portion
            for (int i = n - 2; i >= 0; i--)
            {
                // if there are 0s in the string, we should skip it and look at the next character 
                // because there is no answer when the string begins with 0
                if (s[i] == '0')
                {
                    continue;
                }
                else
                {
                    // When we add a letter from the end of the string, if the first two letters <=26, 
                    // we can get memo[n]=memo[n+1]+memo[n+2]. For example, the String now is “123xxxx” 
                    // and we know all the result from 2. Because 12<26, we can make this string 
                    // either"12"+“3xxxx” or 1+23xxxx which is exactly memo[n]=memo[n-1]+memo[n-2]. 
                    // if the String is"32xxxx" memo[n]=memo[n+1]
                    dp[i] = (int.Parse(s.Substring(i, 2)) <= 26) ? dp[i + 1] + dp[i + 2] : dp[i + 1];
                }
            }

            return dp[0];
        }

        public static int CountNoOfDecodWays(string s)
        {
            if (s.Length < 1)
            {
                return 0;
            }

            int n = s.Length;
            int[] dp = new int[s.Length];

            dp[0] = 1;

            //when there is only 1 charcter in string
            dp[1] = s[0] != '0' ? 1 : 0;

            for (int i = 2; i < n; i++)
            {
                int startIndexF = i - 1;
                int endIndexF = i;
                int first = Convert.ToInt32(s.Substring(startIndexF, endIndexF - startIndexF));

                int startIndexS = i - 2;
                int endIndexS = i;
                int second = Convert.ToInt32(s.Substring(startIndexS, endIndexS - startIndexS));

                if (first >= 1 && first <= 9)
                {
                    dp[i] += dp[i - 1];
                }

                if (second >= 10 && second <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }

            return dp[n];
        }
    }
}
