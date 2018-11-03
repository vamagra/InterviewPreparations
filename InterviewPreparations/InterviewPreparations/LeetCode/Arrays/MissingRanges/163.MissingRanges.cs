using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MissingRanges
    {
        /// <summary>
        /// Given a sorted integer array where the range of elements are [lower, upper] inclusive, return its missing ranges.
        //  For example, given[0, 1, 3, 50, 75], lower = 0 and upper = 99, return ["2", "4->49", "51->74", "76->99"].
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static List<string> GetAllMissingRanges(int[] nums, int lower, int upper)
        {
            List<string> result = new List<string>();
            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            int prevNum = lower - 1; // -1 number from low bound like if range is from 0 to 99 lower would be -1

            for (int i = 0; i <= nums.Length; i++)
            {
                // same here set the upper bound to +1,like if range is from 0 to 99 upper bound would be 100 
                int curr = (i == nums.Length) ? upper + 1 : nums[i];

                if (prevNum + 2 == curr)
                {
                    // here the diff between curr and prev num is just 1 e.g. curr is 2
                    result.Add((prevNum + 1) + "");
                }
                else if (prevNum + 2 < curr)
                {
                    result.Add((prevNum + 1) + "->" + (curr - 1));
                }

                prevNum = curr;
            }

            return result;
        }
    }
}
