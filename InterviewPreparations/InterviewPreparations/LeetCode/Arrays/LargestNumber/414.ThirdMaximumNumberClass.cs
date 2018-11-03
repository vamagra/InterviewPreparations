using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ThirdMaximumNumberClass
    {
        public static int ThirdMax(int[] nums)
        {
            if (nums == null || nums.Length < 1)
            {
                return -1;
            }

            if (nums.Length < 2)
            {
                return nums[0];
            }

            if (nums.Length < 3)
            {
                return nums[0] > nums[1] ? nums[0] : nums[1];
            }

            long max1 = long.MinValue;
            long max2 = long.MinValue;
            long max3 = long.MinValue;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max1 || nums[i] == max2 || nums[i] == max3)
                {
                    continue;
                }

                if (nums[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2 && nums[i] < max1)
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (nums[i] > max3 && nums[i] < max2)
                {
                    max3 = nums[i];
                }
            }

            return max3 == long.MinValue ? (int)max1 : (int)max3;
        }
    }
}
