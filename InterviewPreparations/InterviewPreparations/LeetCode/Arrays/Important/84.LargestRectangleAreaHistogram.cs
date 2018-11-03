using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class LargestRectangleAreaHistogram
    {
        /// <summary>
        //  Given n non-negative integers representing the histogram's bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.
        //  Above is a histogram where width of each bar is 1, given height = [2, 1, 5, 6, 2, 3].
        //  The largest rectangle is shown in the shaded area, which has area = 10 unit.
        //  For example,
        //  Given heights = [2,1,5,6,2,3],
        //  return 10.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int MaxRectangleAreaHistogram(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return 1 * nums[0];
            }

            Stack<int> stack = new Stack<int>();
            int maxArea = 0;
            int i = 0;

            while (i <= nums.Length)
            {
                int val = i < nums.Length ? nums[i] : 0;

                if (stack.Count == 0 || val >= nums[stack.Peek()])
                {
                    // keep pushing the value in the stack if curr value is greater than prev one
                    stack.Push(i);

                    i++;
                }
                else
                {
                    // value of array is hieght
                    int h = nums[stack.Pop()];

                    // index of array is width
                    int w = stack.Count == 0 ? i : i - stack.Peek() - 1;
                    maxArea = Math.Max(maxArea, h * w);
                }
            }

            return maxArea;
        }
    }
}
