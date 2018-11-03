using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MaxConsecutiveOnesClassII
    {
        /// <summary>
        //  Given a binary array, find the maximum number of consecutive 1s in this array if you can flip at most one 0.
        //  Example 1:
        //  Input: [1,0,1,1,0]
        //  Output: 4
        //  Explanation: Flip the first zero will get the the maximum number of consecutive 1s.
        //  After flipping, the maximum number of consecutive 1s is 4.
        //  Note:
        //  The input array will only contain 0 and 1.
        //  The length of input array is a positive integer and will not exceed 10,000
        //  Follow up: What if the input numbers come in one by one as an infinite stream? In other words, you can't store all numbers coming from the stream as it's too large to hold in memory.Could you solve it efficiently?
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            // its two pointer approach
            // count the number of zeros while moving from left to right
            // when you find zero count is greater than k (k is number of zero you can flip)
            // then move the left pointer and search for zero again then decreament the zero count 
            // when you find zero , after the left pointer loop update the max counter
            
            if (nums == null || nums.Length == 1)
            {
                return -1;
            }

            int maxCount = 0;

            int left = 0;
            int zero = 0;
            int k = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zero++;
                }

                while (zero > k)
                {
                    if (nums[left++] == 0)
                    {
                        zero--;
                    }
                }

                maxCount = Math.Max(maxCount, i - left + 1);
            }

            return maxCount;
        }

        public static int FindMaxConsecutiveOnesFromStream(int[] nums)
        {
            // its two pointer approach
            // count the number of zeros while moving from left to right
            // when you find zero count is greater than k (k is number of zero you can flip)
            // then move the left pointer and search for zero again then decreament the zero cunt 
            // when you find zero , after the left pointer loop update the max counter

            if (nums == null || nums.Length == 1)
            {
                return -1;
            }

            int maxCount = 0;

            int left = 0;
            int right = 0;
            int k = 1;
            Queue<int> queue = new Queue<int>();

            for (right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    queue.Enqueue(right);
                }

                if (queue.Count > k)
                {
                    left = queue.Peek() + 1;
                    queue.Dequeue();
                }

                maxCount = Math.Max(maxCount, right - left + 1);
            }

            return maxCount;
        }
    }
}
