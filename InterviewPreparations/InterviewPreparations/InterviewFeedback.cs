using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class InterviewFeedback
    {

        #region Interview I

        #region Question 
        //Find Group of Anagrams
        #endregion

        #region Feedback
        //in general you talked about sorting to check if strings are anagrams of each other which is good.good test cases you came up with. in general, there are a lot of long silences and its sometimes difficult to understand your thought process.practice converting algorithm into code as we couldn't finish coding on time. best of luck!
        #endregion

        #endregion

        #region Interview II

        #region Question
        //using System;

        /*
        dfs/bfs
        greedy
        sliding window
        divide and conquer
        dp
        recursion


        Given a list of float numbers, insert “+”, “-”, “*” or “/” between each consecutive pair of numbers to find the maximum value you can get. For simplicity, assume that all operators are of equal precedence order and evaluation happens from left to right.

        vankaumnii@gmail.com


        Example:
        (1, 12, 3) -> 1 + 12 * 3  = 39

                1              [1]
           13 12 -11 1/12      [1,12]
           .....

        (5, 10, 4) ->
        (-1, 6, -7) - > 



        float getMaxNumber(float[] nums)...
        */

        //class Solution
        //    {
        //        static void Main(string[] args)
        //        {
        //            float[] nums = { 1, 12, -3 }; //33
        //                                          //[-39,33]
        //                                          //float[] nums={1, 12, 5}; //65

        //            float maxNumber = getMaxNumber(nums);

        //            Console.WriteLine(maxNumber);
        //        }

        //        private static float getMaxNumber(float[] nums)
        //        {
        //            // if nums length is < 1

        //            float[] maxResult = new float[2];

        //            if (nums.Length < 1)
        //            {
        //                return maxResult[0];
        //            }

        //            // if nums length is equal 1
        //            if (nums.Length == 1)
        //            {
        //                return nums[0];
        //            }

        //            for (int i = 0; i < nums.Length; i++)
        //            {
        //                maxResult = calculate(maxResult, nums[i]);
        //            }

        //            return maxResult[0] > maxResult[1] ? maxResult[0] : maxResult[1];

        //        }

        //        private static float[] calculate(float[] num1, float num2)
        //        {
        //            List<float> res = new List<float>();

        //            float[] resultMinMax = new float[2];
        //            float sumResult = num1 + num2;
        //            float multiplyResult = num1 * num2;
        //            float minusResult = num1 * num2;
        //            float divideResult = num1 / num2;

        //            resultMinMax[0] = MaxNumber(sumResult, multiplyResult, minusResult, divideResult);

        //            Console.WriteLine(resultMinMax[0]);

        //            resultMinMax[1] = MinNumber(sumResult, multiplyResult, minusResult, divideResult);

        //            Console.WriteLine(resultMinMax[1]);

        //            return resultMinMax;
        //        }

        //        private static float MaxNumber(float sumResult, float multiplyResult, float minusResult, float divideResult)
        //        {
        //            float finalMax = 0;
        //            finalMax = sumResult > multiplyResult ? sumResult : multiplyResult;

        //            finalMax = minusResult > finalMax ? minusResult : finalMax;

        //            finalMax = divideResult > finalMax ? divideResult : finalMax;

        //            return finalMax;
        //        }

        //        private static float MinNumber(float sumResult, float multiplyResult, float minusResult, float divideResult)
        //        {
        //            float finalMin = 0;
        //            finalMin = sumResult > multiplyResult ? multiplyResult : sumResult;

        //            finalMin = minusResult > finalMin ? finalMin : minusResult;

        //            finalMin = divideResult > finalMin ? finalMin : divideResult;

        //            return finalMin;
        //        }




        //    }
        #endregion

        #region Feedback
        //Candidate completed MSc in Computer Applications.Works as a contractor at Microsoft on conversational bots.

        //We worked on the question of Given a sequence of floats and operators, generate the max possible value.

        //Candidate originally proposed a solution that was not addressing all input cases. Once I pointed out, candidate needed further hints to come up with an algorithm.

        //Coding was relatively slow and code structure could be improved. There were also some bugs, e.g.not checking division by zero.

        //I think candidate has a lot of potential. I suggest candidate to continue practicing and make sure to review these algorithmic patterns:
        // DFS/BFS
        // greedy
        // sliding window
        // divide and conquer
        // recursion
        // dynamic programming.

        // Also, review topics of system design, since they may come up in the future interviews.
        #endregion

        #region temp solution
        //        using System;

        //public class Test
        //    {
        //        public static void Main()
        //        {
        //            float[] arr = { -2.0f, -3.0f, -4.0f, .5f };
        //            float intsum = 0;



        //            float resultSum = arr[0];
        //            for (int i = 1; i < arr.Length; i++)
        //            {
        //                resultSum = maxResult(resultSum, arr[i]);
        //            }



        //            Console.WriteLine(resultSum);
        //        }


        //        public static float maxResult(float a, float b)
        //        {
        //            return Math.Max(Math.Max(a + b, a * b),
        //            Math.Max(Math.Max(a / b, b / a), Math.Max(a - b, b - a)));
        //        }

        //    }
        #endregion
        #endregion

        #region Interview III
        #region Question
        //Find maximum(or minimum) sum of a subarray of size k
        #endregion

        #region Feedback
        // He took longer than expected to solve the initial problem.There was no time for a follow up question. He lacks a structured algorithmic approach to problem solving.His initial code looked like a bunch of if else statements.
        // Missed corner cases and the solution initially had serious flaws, until I pointed it out.
        #endregion
        #endregion
    }
}
