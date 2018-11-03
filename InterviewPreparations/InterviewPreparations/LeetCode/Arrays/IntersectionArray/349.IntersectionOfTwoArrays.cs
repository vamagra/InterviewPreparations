using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class IntersectionOfTwoArrays
    {
        /// <summary>
        /// Given two arrays, write a function to compute their intersection.
        //  Example:
        //  Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].
        //  Note:
        //  Each element in the result must be unique.
        //  The result can be in any order.
        // </summary>
        // <param name="nums1"></param>
        // <param name="nums2"></param>
        /// <returns></returns>
        public static int[] IntersectionArray(int[] nums1, int[] nums2)
        {
            if (nums1.Length < 1)
            {
                return nums1;
            }

            if (nums2.Length < 1)
            {
                return nums2;
            }

            List<int> list = new List<int>();
            List<int> resultList = new List<int>();

            // Store all the unique elements in List
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!list.Contains(nums1[i]))
                {
                    list.Add(nums1[i]);
                }
            }

            //if any array item in the list just add that in the resulting list and remove it from first list
            for (int i = 0; i < nums2.Length; i++)
            {
                if (list.Contains(nums2[i]))
                {
                    resultList.Add(nums2[i]);
                    list.Remove(nums2[i]);
                }
            }

            int[] resultArray = new int[resultList.Count];

            for (int i = 0; i < resultList.Count; i++)
            {
                resultArray[i] = resultList[i];
            }

            return resultArray;
        }
    }
}
