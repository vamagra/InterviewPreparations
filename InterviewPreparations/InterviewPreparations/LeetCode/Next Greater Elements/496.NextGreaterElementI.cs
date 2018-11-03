using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class NextGreaterElementI
    {
        /// <summary>
        //  You are given two arrays (without duplicates) nums1 and nums2 where nums1’s elements are subset of nums2. Find all the next greater numbers for nums1's elements in the corresponding places of nums2.
        //  The Next Greater Number of a number x in nums1 is the first greater number to its right in nums2.If it does not exist, output -1 for this number.
        //  Example 1:
        //  Input: nums1 = [4,1,2], nums2 = [1,3,4,2].
        //  Output: [-1,3,-1]
        //  Explanation:
        //  For number 4 in the first array, you cannot find the next greater number for it in the second array, so output -1.
        //  For number 1 in the first array, the next greater number for it in the second array is 3.
        //  For number 2 in the first array, there is no next greater number for it in the second array, so output -1.
        //  Example 2:
        //  Input: nums1 = [2,4], nums2 = [1,2,3,4].
        //  Output: [3,-1]
        //  Explanation:
        //  For number 2 in the first array, the next greater number for it in the second array is 3.
        //  For number 4 in the first array, there is no next greater number for it in the second array, so output -1.
        //  </summary>
        //  <param name="nums1"></param>
        //  <param name="nums2"></param>
        //  <returns></returns>
        public static int[] NextGreater(int[] nums1, int[] nums2)
        {
            if (nums1.Length < 1 || nums2.Length < 1)
            {
                return null;
            }

            IDictionary<int, int> dict = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();

            //Create a dict for next greater element in array2
            for (int i = 0; i < nums2.Length; i++)
            {
                while (stack.Count > 0 && stack.Peek() < nums2[i])
                {
                    dict.Add(stack.Pop(), nums2[i]);
                }

                stack.Push(nums2[i]);
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                if (dict.ContainsKey(nums1[i]))
                {
                    int dictValue = dict[nums1[i]];

                    if (dictValue > nums1[i])
                    {
                        nums1[i] = dictValue;
                    }
                    else
                    {
                        nums1[i] = -1;
                    }
                }
                else
                {
                    nums1[i] = -1;
                }
            }

            return nums1;
        }
    }
}
