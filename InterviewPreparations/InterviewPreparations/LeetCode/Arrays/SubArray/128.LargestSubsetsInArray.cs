using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class LargestSubsetsInArray
    {
        /// <summary>
        /// Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
        //  Your algorithm should run in O(n) complexity.
        //  Example:
        //  Input: [100, 4, 200, 1, 3, 2]
        //  Output: 4
        //  Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>
        public static int LargestContingousSubsetArrayOrLongestConsecutiveSequenceLeetcode(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            //Steps to solve this problem is here

            //1. we will use dictionary to solve this problem

            //2. we will store all the numbers in the hashtable

            //3. now we will check nums[i]-1, if that number is not in the dict that

            //   will determine whether any sequence exists in the list of numbers

            //4. if yes - continue looking for nums[i]+1 in the dict and keep adding into the subsets

            //5. finally get the length of largest LCS

            IDictionary<int, int> dict = new Dictionary<int, int>();

            int lenOfLCS = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], nums[i]);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                //if nums[i]-1 is not in the array then subset starts from here 
                if (!dict.ContainsKey(nums[i] - 1))
                {
                    int temp = nums[i];

                    //keep increasing the number and check if it exist in the list
                    while (dict.ContainsKey(temp))
                    {
                        temp++;
                    }

                    //update the max Length of LCS
                    lenOfLCS = lenOfLCS < temp - nums[i] ? temp - nums[i] : lenOfLCS;
                }
            }

            return lenOfLCS;
        }
    }
}
