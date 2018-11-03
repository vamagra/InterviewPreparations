using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class NextPermutation
    {
        /// <summary>
        /// Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
        //  If such arrangement is not possible, it must rearrange it as the lowest possible order(ie, sorted in ascending order).
        //  The replacement must be in-place and use only constant extra memory.
        //  Here are some examples.Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
        //  1,2,3 → 1,3,2
        //  3,2,1 → 1,2,3
        //  1,1,5 → 1,5,1
        //  </summary>
        //  <param name="nums"></param>
        public static void getNextPermutation(int[] nums)
        {
            /* Solution -> https://www.programcreek.com/2014/06/leetcode-next-permutation-java/
                            The steps to solve this problem:
                1) scan from right to left, find the first element that is less than its previous one.

                4 5 6 3 2 1 
                  |
                  p
                2) scan from right to left, find the first element that is greater than p.

                4 5 6 3 2 1 
                    |
                    q
                3) swap p and q

                4 5 6 3 2 1 
                swap
                4 6 5 3 2 1 
                4) reverse elements [p+1, nums.length]

                4 6 1 2 3 5  

             */
            if (nums != null && nums.Length < 1)
            {
                return;
            }

            // Step 1 - read the array from right and get the number which is samller than its previous e.g. 4 [5 6] 3 2 1  → p=>5
            int p = 0;
            for (int i = nums.Length - 2; i > 0; i--)
            {
                if (nums[i] < nums[i + 1])
                {
                    p = i;
                    break;
                }
            }

            // Step 2 - read the array from right and get the number greater than p e.g. 4 [5 6] 3 2 1  → p=>6
            int q = 0;
            for (int i = nums.Length - 1; i > p; i--)
            {
                if (nums[i] > nums[p])
                {
                    q = i;
                    break;
                }
            }

            // handle the scenario where array is sorted in descending order
            if (p == 0 && q == 0)
            {
                Reverse(nums, 0);
                return;
            }

            // Step 3 - Swap the p and q element; - e.g. 4 [5 6] 3 2 1  => 4 [6 5] 3 2 1 
            int temp = nums[p];
            nums[p] = nums[q];
            nums[q] = temp;

            // Step 4 - Reverse the array from p+1 to nums.Length - e.g. 4 6 [5 3 2 1]  → 4 6 [1 2 3 5] that is the answer
            Reverse(nums, p + 1);
        }

        private static void Reverse(int[] nums, int i)
        {
            int start = i;
            int end = nums.Length - 1;

            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
