using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MajorityElementII
    {
        /// <summary>
        /// Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times. The algorithm should run in linear time and in O(1) space.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> GetMajorityElementArrayII(int[] nums)
        {
            IList<int> result = new List<int>();

            if (nums.Length < 1)
            {
                return result;
            }

            int major1 = 0;
            int major2 = 0;

            int count1 = 0;
            int count2 = 0;

            // get the candidates n1 and n2
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == major1)
                {
                    count1++;
                }
                else if (nums[i] == major2)
                {
                    count2++;
                }
                else if (count1 == 0)
                {
                    count1 = 1;
                    major1 = nums[i];
                }
                else if (count2 == 0)
                {
                    count2 = 1;
                    major2 = nums[i];
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            count1 = 0;
            count2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (major1 == nums[i])
                {
                    count1++;
                }
                else if (major2 == nums[i])
                {
                    count2++;
                }
            }

            if (count1 > (nums.Length / 3))
            {
                result.Add(major1);
            }

            if (count2 > (nums.Length / 3))
            {
                result.Add(major2);
            }

            return result;
        }
    }
}
