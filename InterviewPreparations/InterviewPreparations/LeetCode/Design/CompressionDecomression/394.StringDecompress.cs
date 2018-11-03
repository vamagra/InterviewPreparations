using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class StringDecompress
    {
        /// <summary>
        /// Given an encoded string, return it's decoded string.
        //  The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times.Note that k is guaranteed to be a positive integer.
        //  You may assume that the input string is always valid; No extra white spaces, square brackets are well-formed, etc.
        //  Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k.For example, there won't be input like 3a or 2[4].
        //  Examples:
        //  s = "3[a]2[bc]", return "aaabcbc".
        //  s = "3[a2[c]]", return "accaccacc".
        //  s = "2[abc]3[cd]ef", return "abcabccdcdcdef".
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string StringDecode(string s)
        {
            if (s == null || s.Length < 1)
            {
                return s;
            }

            // Steps -
            // 1. we need to two stack here, one is to store the digits and other is to store the 
            // 2. loop through the expression string
            // 3. if digit - push into the stack (make sure you are handling 2 digit number as well)
            // 4. if left [ - push the last result into resulted stack, make the result string blank and increase the counter
            // 5. if right ] - pop the last result from resulted stack, pop the last count value from digit stack
            //               - run the loop till count and append the resulted string that number of times, update the result string with new build string
            // 6. if char - then add it into the resulted string
                    

            Stack<string> resStack = new Stack<string>();
            Stack<int> countStack = new Stack<int>();

            // counter of string loop
            int index = 0;

            // store the string in this variable, that we need to repeat number of times
            string result = "";

            while (index < s.Length)
            {
                // if this char is digit, need to store in countStack
                if (isDigit(s[index]))
                {
                    int number = 0;

                    // wait, that might be two or more digit number
                    while (isDigit(s[index]) && index < s.Length)
                    {
                        number = number * 10 + s[index] - '0';
                        index++;
                    }

                    // push the count in countStack
                    countStack.Push(number);
                }
                else if (s[index] == '[')
                {
                    // when we found any open bracket, store the last string result in stack
                    resStack.Push(result);

                    // reset the string result variable
                    result = "";

                    index++;
                }
                else if (s[index] == ']')
                {
                    // get the last added result in tempStr
                    StringBuilder tempStr = new StringBuilder(resStack.Pop());

                    // get the repeat item count
                    int repeat = countStack.Pop();

                    // keep appending the result in tempStr, 
                    // which might have last evaluated result
                    for (int i = 0; i < repeat; i++)
                    {
                        tempStr.Append(result);
                    }

                    // assign the tempStr to result
                    result = tempStr.ToString();
                    index++;
                }
                else
                {
                    // keep adding the chars in result
                    result += s[index++];
                }
            }

            return result;
        }

        private static bool isDigit(char ch)
        {
            return ch >= '0' && ch <= '9';
        }
    }
}
