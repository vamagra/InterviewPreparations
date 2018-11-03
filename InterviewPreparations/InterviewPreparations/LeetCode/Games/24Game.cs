using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class _24Game
    {
        /// <summary>
        /// You have 4 cards each containing a number from 1 to 9. You need to judge whether they could operated through *, /, +, -, (, ) to get the value of 24.
        //  Example 1:
        //  Input: [4, 1, 8, 7]
        //  Output: True
        //  Explanation: (8-4) * (7-1) = 24
        //  Example 2:
        //  Input: [1, 2, 1, 2]
        //  Output: False
        //  Note:
        //  The division operator / represents real division, not integer division.For example, 4 / (1 - 2/3) = 12.
        //  Every operation done is between two numbers.In particular, we cannot use - as a unary operator. For example, with[1, 1, 1, 1] as input, the expression -1 - 1 - 1 - 1 is not allowed.
        //  You cannot concatenate numbers together. For example, if the input is [1, 2, 1, 2], we cannot write this as 12 + 12.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static bool JudgePoint24(int[] nums)
        {
            if (nums.Length < 2)
            {
                return false;
            }

            bool[] visited = new bool[4];
            double[] tempArray = new double[4];

            //convert array values in double
            for (int i = 0; i < nums.Length; i++)
            {
                tempArray[i] = 1.0 * nums[i];
            }

            return JudgePoint24helper(visited, tempArray, 4);

        }

        public static bool JudgePoint24helper(bool[] visited, double[] tempArray, int available)
        {
            // will use for backtracking
            double prev = 0;

            if (available == 1)
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (!visited[i])
                    {
                        return Math.Abs(tempArray[i] - 24) < 0.0000001 ? true : false;
                    }
                }
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                prev = tempArray[i];

                for (int j = i + 1; j < tempArray.Length; j++)
                {
                    if (visited[j])
                    {
                        continue;
                    }

                    visited[j] = true;

                    //Add scenario
                    tempArray[i] = prev + tempArray[j];

                    //backtrack for rest of elements
                    if (JudgePoint24helper(visited, tempArray, available - 1))
                    {
                        return true;
                    }

                    //Minus scenario - it will have two sub scenario as A-B is different than B-A
                    tempArray[i] = prev - tempArray[i];

                    //backtrack for rest of elements
                    if (JudgePoint24helper(visited, tempArray, available - 1))
                    {
                        return true;
                    }

                    tempArray[i] = -prev + tempArray[j];

                    //backtrack for rest of elements
                    if (JudgePoint24helper(visited, tempArray, available - 1))
                    {
                        return true;
                    }

                    //Multiply scenario
                    tempArray[i] = prev * tempArray[j];

                    //backtrack for rest of elements
                    if (JudgePoint24helper(visited, tempArray, available - 1))
                    {
                        return true;
                    }


                    //Divide scenario - it will have two sub scenario as A/B is diffrent than B/A
                    tempArray[i] = prev / tempArray[j];

                    //backtrack for rest of elements
                    if (JudgePoint24helper(visited, tempArray, available - 1))
                    {
                        return true;
                    }

                    tempArray[i] = tempArray[j] / prev;

                    //backtrack for rest of elements
                    if (JudgePoint24helper(visited, tempArray, available - 1))
                    {
                        return true;
                    }

                    visited[j] = false;
                }

                tempArray[i] = prev;
            }

            return false;
        }
    }
}
