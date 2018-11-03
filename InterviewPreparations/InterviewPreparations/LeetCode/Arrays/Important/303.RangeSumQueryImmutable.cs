using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    /// Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.
    // Example:
    // Given nums = [-2, 0, 3, -5, 2, -1]

    // sumRange(0, 2) -> 1
    // sumRange(2, 5) -> -1
    // sumRange(0, 5) -> -3
    // Note:
    // You may assume that the array does not change.
    // There are many calls to sumRange function.
    /// </summary>
    class RangeSumQueryImmutable
    {
        int[] sums;
        public RangeSumQueryImmutable(int[] inputNums)
        {
            if (inputNums.Length != 0)
            {
                sums = new int[inputNums.Length];
                sums[0] = inputNums[0];

                for (int i = 1; i < inputNums.Length; i++)
                {
                    //4, 2, -1, 0, -5, 5, 7, 2
                    //current Sum = lastSum + curretValue
                    sums[i] = sums[i - 1] + inputNums[i];
                }
            }               
        }

        public int RangeSum(int i, int j)
        {
            return i == 0 ? sums[j] : sums[j] - sums[i - 1];
        }
    }
}
