using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MajorityElement
    {
        /// <summary>
        /// Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
        //  You may assume that the array is non-empty and the majority element always exist in the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetMajorityElementArray(int[] nums)
        {
            int major = nums[0], count = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    count = 1;
                    major = nums[i];
                }
                else if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return major;
        }

        private static int FindCandidate(int[] nums)
        {
            int maj_Index = 0; int count = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[maj_Index] == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (count == 0)
                {
                    maj_Index = i;
                    count = 1;
                }
            }

            return nums[maj_Index];
        }

        private static bool CheckForMajorIndex(int[] nums, int candidate)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == candidate)
                {
                    count++;
                }
            }

            return count > nums.Length / 2 ? true : false;
        }
    }
}
