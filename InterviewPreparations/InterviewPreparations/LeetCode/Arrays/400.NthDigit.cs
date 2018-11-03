using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class NthDigit
    {
        /// <summary>
        /// Find the nth digit of the infinite integer sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ...
        //  Note:
        //  n is positive and will fit within the range of a 32-bit signed integer(n< 231).
        //  Example 1:
        //  Input:
        //  3
        //  Output:
        //  3
        //  Example 2:
        //  Input:
        //  11
        //  Output:
        //  0
        //  Explanation:
        //  The 11th digit of the sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ... is a 0, which is part of the number 10.
        //  </summary>
        //  <param name="n"></param>
        //  <returns></returns>
        public static int GetDigit(int n)
        {
            // to get the length of resulted number
            int len = 1;

            // end number of the range in which resulted digit can be found
            long count = 9;

            // start number of the range in which resulted digit can be found
            int start = 1;


            while (n > len * count)
            {
                // decrease the n for length * end range number to get the actual number
                n -= len * (int)count;

                // increase the len of number in every iteration
                len += 1;

                // reset the end number for the range
                count *= 10;

                // reset the start numbe for the range
                start *= 10;
            }

            // here we will get the actual number
            // start range + (n-1) / length of the actual number
            start = start + (n - 1) / len;

            string s = Convert.ToString(start);

            char ch = (s[(n - 1) % len]);
            // return the 
            return Convert.ToInt32(char.GetNumericValue(ch));
        }
    }
}
