using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class SummaryRanges
    {
        /// <summary>
        /// Given a sorted integer array without duplicates, return the summary of its ranges.
        //  Example 1:
        //  Input:  [0,1,2,4,5,7]
        //  Output: ["0->2","4->5","7"]
        //  Explanation: 0,1,2 form a continuous range; 4,5 form a continuous range.
        //  Example 2:
        //  Input:  [0,2,3,4,6,8,9]
        //  Output: ["0","2->4","6","8->9"]
        //  Explanation: 2,3,4 form a continuous range; 8,9 form a continuous range.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static List<string> SummaryRange(int[] nums)
        {
            List<string> result = new List<string>();

            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            if (nums.Length == 1)
            {
                result.Add(Convert.ToString(nums[0]));
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int curr = nums[i];

                while (i + 1 < nums.Length && (nums[i + 1] - nums[i]) == 1)
                {
                    i++;
                }

                if (curr != nums[i])
                {
                    result.Add(curr + "->" + nums[i]);
                }
                else
                {
                    result.Add(curr + "");
                }
            }

            return result;
        }
    }
}
