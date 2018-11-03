using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays.Important
{
    class ArrayIndexElementEquality
    {
        /// <summary>
        //  Given a sorted array arr of distinct integers, write a function indexEqualsValueSearch that returns the lowest index i for which arr[i] == i. 
        //  Return -1 if there is no such index. Analyze the time and space complexities of your solution and explain its correctness.
        //  Examples:
        //  Input: arr = [-8,0,2,5]
        //  output: 2 # since arr[2] == 2
        //  Input: arr = [-1,0,3,6]
        //  output: -1 # since no index in arr satisfies arr[i] == i.
        //  Constraints:
        //  [time limit] 5000ms
        //  [input] array.integer arr
        //  1 ≤ arr.length ≤ 100
        //  [output] integer
        //  </summary>
        //  <param name="arr"></param>
        //  <returns></returns>
        public static int ArrayIndex(int[] arr)
        {
            // your code goes here
            if (arr.Length < 1)
            {
                return -1;
            }

            int begin = 0;
            int end = arr.Length - 1;

            while (begin <= end)
            {
                int mid = (begin + end) / 2;

                if (arr[mid] == mid)
                {
                    return mid;
                }

                if (arr[mid] >= mid)
                {
                    end = mid - 1;
                }
                else
                {
                    begin = mid + 1;
                }
            }

            return -1;
        }
    }
}
