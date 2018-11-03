using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class HammingDistance
    {
        /// <summary>
        /// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
        //  Given two integers x and y, calculate the Hamming distance.
        //  Note:
        //  0 ≤ x, y< 231.
        //  Example:
        //  Input: x = 1, y = 4
        //  Output: 2
        //  Explanation:
        //  1   (0 0 0 1)
        //  4   (0 1 0 0)
        //  ↑   ↑
        //  The above arrows point to positions where the corresponding bits are different.
        //  </summary>
        //  <param name="x"></param>
        //  <param name="y"></param>
        //  <returns></returns>
        public static int GetHammingDistanceValue(int x, int y)
        {
            #region Solution Explained
            // XOR returns no.of bits that are not same.
            // 0 ^ 0 - 0
            // 0 ^ 1 - 1
            // 1 ^ 0 - 1
            // 1 ^ 1 - 0
            // Your case:
            // 7-- > 0 1 1 1
            // 8-- > 1 0 0 0
            // ----------------
            // 7 ^ 8-- > 1 1 1 1

            //You may notice 7 and 8 have 4 bits different. When you do AND operation on this result until it is zero, we get the count of set bits.
            #endregion
            int num3 = x ^ y;

            int count = 0;

            while (num3 > 0)
            {
                num3 = num3 & (num3 - 1);
                count++;
            }

            return count;
        }
    }
}
