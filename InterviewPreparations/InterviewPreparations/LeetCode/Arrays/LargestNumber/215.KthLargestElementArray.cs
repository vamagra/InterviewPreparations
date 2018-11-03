﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class KthLargestElementArray
    {
        /// <summary>
        /// Find the kth largest element in an unsorted array. Note that it is the kth largest element in the sorted order, not the kth distinct element.
        //  For example,
        //  Given[3, 2, 1, 5, 6, 4] and k = 2, return 5.
        //  Note: 
        //  You may assume k is always valid, 1 ≤ k ≤ array's Length.
        //  </summary>
        // <param name="nums"></param>
        //  <param name="k"></param>
        //  <returns></returns>
        
        public static int findKthLargest(int[] nums, int k)
        {
            // Time Complexity - O (nLog(n))
            if (nums == null || nums.Length == 0)
            {
                return int.MaxValue;
            }

            return findKthLargest(nums, 0, nums.Length - 1, nums.Length - k);
        }

        public static int findKthLargest(int[] nums, int start, int end, int k)
        {
            // quick select: kth smallest
            if (start > end)
            {
                return int.MaxValue;
            }

            int pivot = nums[end]; // Take A[end] as the pivot,
             
            int left = start;

            for (int i = start; i < end; i++)
            {
                if (nums[i] <= pivot) // Put numbers < pivot to pivot's left
                    swap(nums, left++, i);
            }

            swap(nums, left, end);// Finally, swap A[end] with A[left]

            if (left == k)// Found kth largest number
            {
                return nums[left];
            }
            else if (left < k)// Check right part
            {
                return findKthLargest(nums, left + 1, end, k);
            }
            else // Check left part
            {
                return findKthLargest(nums, start, left - 1, k);
            }
        }

        private static void swap(int[] a, int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}
