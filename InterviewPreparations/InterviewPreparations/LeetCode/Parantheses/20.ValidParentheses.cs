using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewQuestions.StackClass;

namespace InterviewQuestions.LeetCode
{
    class ValidParentheses
    {
        /// <summary>
        /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        //  The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            bool IsResulted = false;

            Stack<char> st = new Stack<char>();

            if (s.Length <= 1)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '(' || s[i] == '[')
                {
                    st.Push(s[i]);
                }

                if (s[i] == '}' || s[i] == ')' || s[i] == ']')
                {
                    if (st.Count != 0)
                    {
                        char ch = st.Pop();

                        if (IsMatching(ch, s[i]))
                        {
                            IsResulted = true;
                        }
                        else
                        {
                            IsResulted = false;
                            break;
                        }
                    }
                    else
                    {
                        IsResulted = false;
                    }
                }

            }

            if (st.Count != 0)
            {
                IsResulted = false;
            }

            return IsResulted;
        }

        private static bool IsMatching(char ch, char ch1)
        {
            if (ch == '{' && ch1 == '}' || ch == '(' && ch1 == ')' || ch == '[' && ch1 == ']')
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
