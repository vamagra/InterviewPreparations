using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class FindAllDuplicateNumbers
    {
        /// <summary>
        /// Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
        //  Find all the elements that appear twice in this array.
        //  Could you do it without extra space and in O(n) runtime?
        //  Example:
        //  Input:
        //  [4,3,2,7,8,2,3,1]
        //  [4,3,2,-7,8,2,3,1]
        //  [4,3,-2,-7,8,2,3,1]
        //  [4,-3,-2,-7,8,2,3,1]
        //  [4,-3,-2,-7,8,2,-3,1]
        //  [4,-3,-2,-7,8,2,-3,-1]
        //  Output:
        //  [2,3]
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();

            if (nums.Length < 1)
            {
                return result;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = Math.Abs(nums[i]);

                if (nums[currValue - 1] < 0)
                {
                    result.Add(currValue);
                }

                nums[currValue - 1] = -nums[currValue - 1];
            }

            return result;
        }
    }
}
