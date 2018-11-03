using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ValidNumber
    {
        /// <summary>
        /// Validate if a given string is numeric.
        //  Some examples:
        //  "0" => true
        //  " 0.1 " => true
        //  "abc" => false
        //  "1 a" => false
        //  "2e10" => true
        //  Note: It is intended for the problem statement to be ambiguous.
        // You should gather all requirements up front before implementing one.

        //Update (2015-02-10):
        //The signature of the C++ function had been updated.If you still see your function signature accepts a const char* argument, please click the reload button  to reset your code definition.

        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNumber(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            bool pointSeen = false;
            bool eSeen = false;
            bool numberSeen = false;
            bool numberAfterE = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    numberSeen = true;
                    numberAfterE = true;
                }
                else if (s[i] == '.')
                {
                    //1. point cannot multiple in number
                    //2. point cannot be in Exponential number
                    if (pointSeen || eSeen)
                    {
                        return false;
                    }

                    pointSeen = true;
                }
                else if (s[i] == 'e')
                {
                    //1. e cannot be multiple in number
                    //2. if there is no number in the string, e cannot be occur
                    if (eSeen || !numberSeen)
                    {
                        return false;
                    }

                    eSeen = true;
                    numberAfterE = false;
                }
                else if (s[i] == '-' || s[i] == '+')
                {
                    //if this is not the first place
                    //if previous char is not e then return false
                    if (i != 0 && s[i - 1] != 'e')
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return numberSeen && numberAfterE;
        }
    }
}
