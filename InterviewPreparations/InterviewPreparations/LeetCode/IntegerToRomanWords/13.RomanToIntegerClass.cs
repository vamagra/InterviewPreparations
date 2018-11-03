using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RomanToIntegerClass
    {
        /// <summary>
        //  Given a roman numeral, convert it to an integer.
        //  Input is guaranteed to be within the range from 1 to 3999.
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static int RomanToInteger(string s)
        {
            int result = 0;

            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            //store the maping in hashmap
            IDictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            int len = s.Length;

            // Idea is quite simple here
            // 1. create a mapping of roman char values
            // 2. add the last char roman value in result.
            // 3. run the loop from end and check below two condition
            // 4.   - if the second last char is greater than last char then add the roman value in result (VI, 5 is greater than 1 so add 5 + 1 =6) 
            // 5.   - other wise remove the roman value from string (IV, 1 is less than 4 so substract 5 - 1 = 4) 

            //store the last char roman value in result
            result = dict[s[len - 1]];

            //read the string from back
            for (int i = len - 2; i >= 0; --i)
            {
                // if second last char roman value is greater than last char roman value
                // then 
                if (dict[s[i]] >= dict[s[i + 1]])
                {
                    result += dict[s[i]];
                }
                else
                {
                    result -= dict[s[i]];
                }
            }

            return result;
        }
    }
}
