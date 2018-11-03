using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class EliminatePairs
    {
        /// <summary>
        //  You are given a string. You have to eliminate the pairs (two same chars adjacent to each other).
        //  eg.input string RGBBGBGR –> RGGBGR–> RBGR(output)
        //  </summary>
        //  <param name="ch"></param>
        //  <returns></returns>

        // using stack
        public static string RemoveAdjacentPairsInStringUsingStack(char[] ch)
        {
            if (ch != null && ch.Length < 1)
            {
                return ch.ToString();
            }

            Stack<char> stack = new Stack<char>();
            stack.Push(ch[0]);

            for (int i = 1; i < ch.Length; i++)
            {
                if (stack.Count > 0)
                {
                    if (stack.Peek() == ch[i])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(ch[i]);
                    }
                }
            }

            StringBuilder result = new StringBuilder();

            while (stack.Count != 0)
            {
                result.Append(stack.Pop());
            }

            return result.ToString();

        }

        public static string RemoveAdjacentPairsInString(char[] ch)
        {
            if (ch != null && ch.Length < 1)
            {
                return ch.ToString();
            }

            int i = 1;
            int j = 0;

            for (i = 1; i < ch.Length; i++)
            {
                while (ch[i] == ch[j] && j > 0)
                {
                    i++;
                    j--;
                }

                ch[++j] = ch[i];
            }

            return ch.ToString();
        }
        
    }
}
