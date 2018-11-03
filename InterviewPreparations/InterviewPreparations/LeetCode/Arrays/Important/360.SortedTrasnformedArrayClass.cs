using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SortedTrasnformedArrayClass
    {
        /// <summary>
        /// Given a sorted array of integers nums and integer values a, b and c. 
        //  Apply a function of the form f(x) = ax2 + bx + c to each element x in the array.
        //  The returned array must be in sorted order.
        //  Expected time complexity: O(n)
        //  Example:
        //  nums = [-4, -2, 2, 4], a = 1, b = 3, c = 5,
        //  Result: [3, 9, 15, 33]
        //  nums = [-4, -2, 2, 4], a = -1, b = 3, c = 5
        //  Result: [-23, -5, 1, 7]
        //  </summary>
        //  <param name="nums"></param>
        //  <param name="a"></param>
        //  <param name="b"></param>
        //  <param name="c"></param>
        //  <returns></returns>
        public static int[] TransformedArray(int[] nums, int a, int b, int c)
        {
            // solution ref - http://shirleyisnotageek.blogspot.com/2016/10/sort-transformed-array.html
            if (nums != null && nums.Length < 1)
            {
                return null;
            }

            int start = 0;
            int end = nums.Length - 1;

            int startCounter = 0;
            int endCounter = nums.Length - 1;

            int[] result = new int[nums.Length];

            while (start <= end)
            {
                // calculte result from left and right both
                int first = calculate(nums[start], a, b, c);
                int second = calculate(nums[end], a, b, c);

                // a>=0 then result would 
                if (a >= 0)
                {
                    // if first is greater than second result then store first at the end of result, move from left
                    if (first > second)
                    {
                        result[endCounter--] = first;
                        start++;
                    }
                    // if second is greater than first result then store second at the end of result, move from right
                    else
                    {
                        result[endCounter--] = second;
                        end--;
                    }
                }
                else
                {
                    if (first > second)
                    {
                        result[startCounter++] = first;
                        start++;
                    }
                    else
                    {
                        result[startCounter++] = second;
                        end--;
                    }
                }
            }

            return result;
        }

        public static int calculate(int x, int a, int b, int c)
        {
            return (a * x * x) + (b * x) + c;
        }

    }
}
