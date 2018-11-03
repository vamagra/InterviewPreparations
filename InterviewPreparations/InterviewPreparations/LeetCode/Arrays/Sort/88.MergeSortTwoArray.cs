
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MergeSortTwoArray
    {
        /// <summary>
        /// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
        //  Note: You may assume that nums1 has enough space(size that is greater or equal to m + n) to hold additional elements from nums2.The number of elements initialized in nums1 and nums2 are m and n respectively.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="n"></param>
        /// <param name="nums2"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int[] MergeSort(int[] A, int n, int[] B, int m)
        {
            if (n <= 0 && m <= 0)
            {
                return null;
            }

            if (n <= 0)
            {
                return B;
            }

            if (m <= 0)
            {
                return A;
            }

            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (A[i] > B[j])
                {
                    A[k--] = A[i--];
                }
                else
                {
                    A[k--] = B[j--];
                }
            }

            while (j >= 0)
                A[k--] = B[j--];

            //for (int k = m + n - 1; k >= 0; k--)
            //{
            //    if (i < 0 || j < 0)
            //    {
            //        break;
            //    }
            //    else if (nums1[i] <= nums2[j])
            //    {
            //        nums1[k] = nums2[j];
            //        j--;
            //    }
            //    else if(nums1[i] >= nums2[j])
            //    {
            //        nums1[k] = nums1[i];
            //        i--;
            //    }
            //    else if (i == 0)
            //    {
            //        nums1[k] = nums2[j--];
            //    }
            //    else if (j == 0)
            //    {
            //        nums1[k] = nums1[i--];
            //    }
            //}

            return A;
        }
    }
}
