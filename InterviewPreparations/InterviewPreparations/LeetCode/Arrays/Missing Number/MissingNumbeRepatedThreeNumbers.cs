using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MissingNumbeRepatedThreeNumbers
    {
        /// <summary>
        //  Given a contiguous sequence of numbers in which each number repeats thrice, 
        //  there is exactly one missing number. Find the missing number.
        //  eg: 11122333 : Missing number 2
        //  11122233344455666 Missing number 5
        //  </summary>
        //  <param name="s"></param>
        //  <returns></returns>
        public static int MissingNumber(string s)
        {
            if (s == null || s.Length < 1)
            {
                return -1;
            }

            char[] chArray = s.ToCharArray();

            int count = 1;
            for (int i = 2; i < chArray.Length; i = i + 3)
            {
                if (chArray[i] - '0' != count)
                {
                    return count;
                }

                count++;
            }

            return count;
        }

        public int findMissingNumber(string num)
        {
            char[] arr = num.ToCharArray();

            int left = arr[0] - '0';
            int right = arr[arr.Length - 1] - '0';

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (arr[(mid - 1) * 3 + 2] - '0' == mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
