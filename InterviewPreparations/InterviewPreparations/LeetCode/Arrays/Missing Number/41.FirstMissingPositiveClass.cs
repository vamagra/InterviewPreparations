using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class FirstMissingPositiveClass
    {
        /// <summary>
        /// Given an unsorted integer array, find the first missing positive integer.
        //  For example,
        //  Given[1, 2, 0] return 3,
        //  and[3, 4, -1, 1] return 2.
        //  Your algorithm should run in O(n) time and uses constant space.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        #region Explanation
        //  number i should be in index i-1 of nums.
        //  keep pushing number A into its right place, and push out the existing number B from this place 
        //  and continue push number B into its right place again.
        //  i.e.start from the first number 3
        //  Index: 0, 1, 2, 3, 4
        //  Array: 3, 4, 5, 1, -1 curr number 3
        //  Array: 3, 4, 3, 1, -1 push 3 to index 2, the number being pushed out is 5
        //  Array: 3, 4, 3, 1, 5 push 5 to index 4, the number being pushed out is -1, so we stop.
        //  Array: 3, 4, 3, 4, 5 next number is 4, push 4 to index 3, the number being pushed out is 1
        //  Array: 1, 4, 3, 4, 5 push 1 to index 0, the number being pushed out is 3
        //  Array: 1, 4, 3, 4, 5 since 3 is already at index 2 (right place), we stop
        //  check next number is 3 (already right place), then 4 (right place), then 5 (right place), stop.
        //  Now we compare each number with its index, should be number == index+1, otherwise the number is the first missing positive.
        #endregion
        public static int FindFirstMissingPositive(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 0;
            }

            // Idea here is to put the number at the correct index 
            // 2 should be at 2nd index 
                // - like i value should be i-1 index, if the number is greater than array length just ignore it
                // - and number should be greater than 0 as well
                // - number should not be equal to previous number

            //  once all the i number placed at correct index then loop the array again
            //  check for current element with index nums[j] != j+1 (beacuse index starts from 0)

            int N = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                int curr = nums[i];

                // 1. if curr is greater than 0 && curr is less than total elements
                // 2. if curr is not equal to nums[curr-1] whether curr number is on right place or not
                while (curr > 0 && curr <= N && curr != nums[curr - 1])
                {
                    //swap the curr element with curr index
                    //like if 
                    int temp = nums[curr - 1];
                    nums[curr - 1] = curr;
                    curr = temp;
                }
            }

            // compare the number with index + 1
            int j;
            for (j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                {
                    break;
                }
            }

            return j + 1;
        }
    }
}
