using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SolveTheEquationClass
    {
        /// <summary>
        /// Solve a given equation and return the value of x in the form of string "x=#value". The equation contains only '+', '-' operation, the variable x and its coefficient.
        //  If there is no solution for the equation, return "No solution".
        //  If there are infinite solutions for the equation, return "Infinite solutions".
        //  If there is exactly one solution for the equation, we ensure that the value of x is an integer.
        //  Example 1:
        //  Input: "x+5-3+x=6+x-2"
        //  Output: "x=2"
        //  Example 2:
        //  Input: "x=x"
        //  Output: "Infinite solutions"
        //  Example 3:
        //  Input: "2x=x"
        //  Output: "x=0"
        //  Example 4:
        //  Input: "2x+3x-6x=x+2"
        //  Output: "x=-1"
        //  Example 5:
        //  Input: "x=x+2"
        //  Output: "No solution"
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static string SolveEquation(string s)
        {
            #region Solution
        //            Example
        //e.g.x + 5 - 3 + x = 6 + x - 2

        //Firstly, we split the equation by "=":
        //leftPart is x + 5 - 3 + x;
        //            rightPart is 6 + x - 2;
        //            Secondly, we sum up coefficient and the rest numbers separately, i.e.
        //            leftVals is 2x + 2, i.e., [2, 2];
        //rightVals is x + 4, i.e., [1, 4];
        //Thirdly, we solve the simplified equation by moving all elements to the left of "=",
        //cntX = leftVals[0] - rightVals[0];, i.e., 2 - 1 = 1,
        //cntNum = leftVals[1] - rightVals[1];, i.e., 2 - 4 = -2,
        //cntX* x + cntNum = 0, i.e., 1 * x + (-2) = 0,
        //x = (-cntNum) / cntX, i.e., x = 2
        //Please note that
        //exp.split(""); split exp by 0-length string ("a+b-c" to "a", "+", "b", "-", "c")
        //exp.split("(?=[-+])");split exp by 0-length string only if they are follow by "-" or "+" ("a+b-c" to "a", "+b", "-c")
            #endregion

            // Step to Solve this probelm
            // Step1  - Split the string with '=' to split the left and right parts
            // Step2  - Split the left and right part with [+,-] so split string will end up coefficent (how many X values) and constants (5)
            // Step3  - now count the +X, -X, X and Constant from left part in left array
            // Step4  - now count the +X, -X, X and Constant from right part in right array
            // Step 5 - now get the left Coefficent form deducting left and right array
            // Step 6 - now get the right constant from deducting left and right array
            // Step 7 - now solve the equation - countX * X + countNum = 0; => X = -countNum/countX;
            // Step 8 - store the result and reply.

            if (s == null || s.Length == 0)
            {
                return "";
            }

            string[] splitLeftRightPartsEqual = s.Split('=');

            // left part
            int[] leftvalues = Evaluate(splitLeftRightPartsEqual[0]);

            // right part
            int[] rightValues = Evaluate(splitLeftRightPartsEqual[1]); 

            // count number of X both sides
            int countX = leftvalues[0] - rightValues[0];

            // count number of constant both sides
            int countNum = leftvalues[1] - rightValues[1];

            if (countX == 0)
            {
                if (countNum != 0)
                {
                    return "No Solution";
                }

                return "Infine Solutions";
            }

            // countX * resultX + countNum = 0;
            int resultX = -countNum / countX;

            return Convert.ToString("x=" + resultX);
        }

        private static int[] Evaluate(string exp)
        {
            // result[0] - to store x+, x- 
            // result[1] - to store constant
            int[] result = new int[2];

            string[] splitEquation = Regex.Split(exp, "(?=[+-])");

            foreach (string element in splitEquation)
            {
                if (!string.IsNullOrEmpty(element))
                {
                    if (element.Equals("+x") || element.Equals("x"))
                    {
                        result[0]++;
                    }
                    else if (element.Equals("-x"))
                    {
                        result[0]--;
                    }
                    else if (element.Contains("x"))
                    {
                        result[1] += int.Parse(element.Substring(0, element.IndexOf("x")));
                    }
                    else
                    {
                        result[1] += int.Parse(element);
                    }
                }
            }
            return result;
        }
    }
}
