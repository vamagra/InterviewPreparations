using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays
{
    class MinimumMovesEqualArray
    {
        /// <summary>
        /// Given a non-empty integer array of size n, find the minimum number of moves required to make all array elements equal, where a move is incrementing n - 1 elements by 1.
        //  Example:
        //  Input:
        //  [1,2,3]
        //  Output:
        //  3
        //  Explanation:
        //  Only three moves are needed(remember each move increments two elements):
        //  [1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int MinimumMoves(int[] nums)
        {
            // Explnation 
            // Another way to arrive at this logic:
            // Adding 1 to n-1 elements is equivalent to subtracting 1 from one element. 
            // So, all the elements should become 'min' element by the end of transformations. 
            // We need nums[i] - min steps for element i.
            // So the total number of moves required(and that will the minimum) are sum - min * n.

            if (nums.Length < 1)
            {
                return -1;
            }

            int sum = 0;
            int minNumber = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (nums[i] < minNumber)
                {
                    minNumber = nums[i];
                }
            }

            return sum - minNumber * nums.Length;
        }
    }
}
