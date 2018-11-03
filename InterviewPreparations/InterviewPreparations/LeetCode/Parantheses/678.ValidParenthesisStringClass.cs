using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class ValidParenthesisStringClass
    {
        /// <summary>
        //  Given a string containing only three types of characters: '(', ')' and '*', 
        //  write a function to check whether this string is valid. We define the validity of a string by these rules:
        //  Any left parenthesis '(' must have a corresponding right parenthesis ')'.
        //  Any right parenthesis ')' must have a corresponding left parenthesis '('.
        //  Left parenthesis '(' must go before the corresponding right parenthesis ')'.
        //  '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string.
        //  An empty string is also valid.
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static bool ValidParaenthesis(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (s.Length == 1 && s[0] != '*')
            {
                return false;
            }

            Stack<char> st = new Stack<char>();

            bool result = false;

            int isValidChar = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    isValidChar++;
                    continue;
                }

                if (s[i] == '(')
                {
                    st.Push(s[i]);
                }
                else
                {
                    if (st.Count != 0)
                    {
                        char popUpCh = st.Pop();

                        if (IsMatching(popUpCh, s[i]))
                        {
                            result = true;
                        }
                        else
                        {
                            if (isValidChar > 0)
                            {
                                result = true;
                                isValidChar--;
                            }
                            else
                            {
                                result = false;
                            }
                        }
                    }
                    else
                    {
                        if (isValidChar > 0)
                        {
                            result = true;
                            isValidChar--;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }

            if (st.Count != 0 && isValidChar == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            if (isValidChar > 0)
            {
                if (st.Count == isValidChar)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool IsMatching(char ch1, char ch2)
        {
            if (ch1 == '(' && ch2 == ')')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
