using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class IntersectionTwoArraysII
    {
        /// <summary>
        /// Given two arrays, write a function to compute their intersection.
        //  Example:
        //  Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].
        //  Note:
        //  Each element in the result should appear as many times as it shows in both arrays.
        //  The result can be in any order.
        //  Follow up:
        //  What if the given array is already sorted? How would you optimize your algorithm?
        //  What if nums1's size is small compared to nums2's size? Which algorithm is better?
        //  What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
        //  </summary>
        //  <param name="nums1"></param>
        //  <param name="nums2"></param>
        //  <returns></returns>
        public static int[] IntersectionArray(int[] nums1, int[] nums2)
        {
            if (nums1.Length < 1)
            {
                return nums2;
            }

            if (nums2.Length < 1)
            {
                return nums1;
            }

            //Store the freq in the dict of array1
            IDictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (dict.ContainsKey(nums1[i]))
                {
                    dict[nums1[i]] = dict[nums1[i]] + 1;
                }
                else
                {
                    dict.Add(nums1[i], 1);
                }
            }

            List<int> resultedList = new List<int>();

            // now if array 2 element is present in the array then add it into resulting list
            // subtract the freq from dict
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
                {
                    resultedList.Add(nums2[i]);
                    dict[nums2[i]]--;
                }
            }

            int[] resultArray = new int[resultedList.Count];

            int counter = 0;
            foreach(int item in resultedList)
            {
                resultArray[counter++] = item;
            }

            return resultArray;
        }
    }
}
