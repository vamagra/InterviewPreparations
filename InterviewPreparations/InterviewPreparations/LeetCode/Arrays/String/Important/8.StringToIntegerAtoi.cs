using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class StringToIntegerAtoi
    {
        /// <summary>
        /// Implement atoi to convert a string to an integer.
        //  Hint: Carefully consider all possible input cases.If you want a challenge, please do not see below and
        //  ask yourself what are the possible input cases.
        //  Notes: It is intended for this problem to be specified vaguely (i.e, no given input specs).
        //  You are responsible to gather all the input requirements up front.
        //  </summary>
        //  <param name="str"></param>
        //  <returns></returns>
        public static int MyAtoi(string str)
        {
            int resultedNum = 0;
            bool specialChar = false;

            str = str.Trim();

            //if string is empty
            if (string.IsNullOrEmpty(str))
            {
                return resultedNum;
            }

            // if length == 1, if char
            if (str.Length == 1)
            {
                if(IsNumeric(str[0]))
                {
                    return str[0] - '0';
                }
                else
                {
                    return 0;
                }
            }

            int sign = 1;
            int i = 0;

            if (str[0] == '-')
            {
                sign = -1;
                i = i + 1;
                specialChar = true;
            }

            for (; i < str.Length; i++)
            {
                if (!IsNumeric(str[i]))
                {
                    if (specialChar || sign == -1)
                    {
                        return 0;
                    }

                    specialChar = true;
                    continue;
                }

                resultedNum = (resultedNum * 10) + str[i] - '0';
            }
             
            return resultedNum * sign;
        }

        private static bool IsNumeric(char ch)
        {
            return (ch >= '0' && ch <= '9') ? true : false; 
        }
    }
}
