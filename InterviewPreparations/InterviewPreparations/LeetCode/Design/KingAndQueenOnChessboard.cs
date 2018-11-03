using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode.Trick
{
    /// <summary>
    /// Problem statement is to check if the King is threatened by a queen
    /// </summary>
    class KingAndQueenOnChessboard
    {
        public static bool CheckMate(int kX, int kY, int qX, int qY)
        {
            //here we have scenarios that we need to check to make sure if king is threaten by queen

            // 1. Horizontal - If Qx is Equal to Kx then king is threatend
            // 2. Veritcal  - if Qy is Equal to Ky then King is threatend
            // 3. Diagonal - if ABS|Kx-Qx| == ABS|Ky-Qy|

            int[] nums = new int[4];
            nums[0] = kX;
            nums[1] = kY;
            nums[2] = qX;
            nums[3] = qY;

            if (!ValidInput(nums))
            {
                return false;
            }

            if (kX == qX || kY == qY || Math.Abs(kX - qX) == Math.Abs(kY - qY))
            {
                return true;
            }

            return false;

        }

        private static bool ValidInput(int[] nums)
        {
            foreach (var el in nums)
            {
                if (el < 1 && el > 8)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
