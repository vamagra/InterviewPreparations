using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class FindTheDuplicateNumber
    {
        /// <summary>
        /// Given an array nums containing n + 1 integers where each integer is between 1 and n (inclusive), prove that at least one duplicate number must exist. Assume that there is only one duplicate number, find the duplicate one.
        //  Note:
        // You must not modify the array(assume the array is read only).
        // You must use only constant, O(1) extra space.
        // Your runtime complexity should be less than O(n2).
        // There is only one duplicate number in the array, but it could be repeated more than once.
        //  </summary>
        //  <param name="nums"></param>
        //  <returns></returns>

        public static int FindDuplicate(int[] nums)
        {
            #region Sorting Solution
            //if (nums.Length < 1)
            //{
            //    return -1;
            //}

            //Array.Sort(nums);

            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] == nums[i - 1])
            //    {
            //        return nums[i];
            //    }
            //}

            //return -1;
            #endregion

            #region Slow Fast Pointer Solution

            // The main idea is the same with problem Linked List Cycle II,https://leetcode.com/problems/linked-list-cycle-ii/. 
            // Use two pointers the fast and the slow. The fast one goes forward two steps each time, while the slow 
            // one goes only step each time. They must meet the same item when slow==fast. In fact, they meet in a circle, 
            // the duplicate number must be the entry point of the circle when visiting the array from nums[0]. Next we just need 
            // to find the entry point. We use a point(we can use the fast one before) to visit form begining with one step each time, 
            // do the same job to slow. When fast==slow, they meet at the entry point of the circle
            // The idea is to consider array items as linked list nodes. Any particular index is pointing to the value at that index. And you will see that there is loop as shown in the image below - In case of duplicate, two indexes will have same value and they will form a cycle just like in the image given below.
            //  Linked list formed for above example would be :
            //  1->2->3->4->5->6->3
            //  So we can find the entry point of cycle in the linked list and that will be our duplicate element.
            //  We maintain two pointers fast and slow
            //  For each step fast will move to the index that is equal to arr[arr[fast]](two jumps at a time) and slow will move to the index arr[slow](one step at a time)
            //  When fast == slow that means now we are in a cycle.
            //  Fast and slow will meet in a circle and the entry point of that circle will be the duplicate element.
            //  Now we need to find entry point so we will start with fast = 0 and visit one step at a time for both fast and slow.
            //  When fast == slow that will be entry point.
            //  Return the entry point.

            #endregion

            if (nums.Length < 1)
            {
                return -1;
            }

            int slow = nums[0];
            int fast = nums[0];

            // get the intersection point
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }
            while (slow != fast);

            // Find the entrance in cycle
            int ptr1 = nums[0];
            int ptr2 = slow;

            while (ptr1 != ptr2)
            {
                ptr1 = nums[ptr1];
                ptr2 = nums[ptr2];
            }

            return ptr1;
           
            //if (nums.Length < 1)
            //{
            //    return -1;
            //}

            //// here we are making the currValue - 1 value negative, if duplicate
            //// if specific index value is already negative then return index+1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int index = Math.Abs(nums[i]) - 1;

            //    if (nums[index] < 0)
            //    {
            //        return index + 1;
            //    }

            //    nums[index] = -nums[index];
            //}

            //return -1;
        }
    }
}
