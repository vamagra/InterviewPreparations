using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class RectangleArea
    {
        /// <summary>
        /// Find the total area covered by two rectilinear rectangles in a 2D plane.
        /// Each rectangle is defined by its bottom left corner and top right corner as shown in the figure.
        /// Rectangle Area 
        //  Assume that the total area is never beyond the maximum possible value of int.
        /// </summary>
        /// <param name="R1BL"></param>
        /// <param name="R1TL"></param>
        /// <param name="R1TR"></param>
        /// <param name="R1BR"></param>
        /// <param name="R2BL"></param>
        /// <param name="R2TL"></param>
        /// <param name="R2TR"></param>
        /// <param name="R2BR"></param>
        /// <returns></returns>
        public static int CalculateArea(int R1BL, int R1TL, int R1BR, int R1TR, int R2BL, int R2TL, int R2BR, int R2TR)
        {
            int totalArea = -1;

            int x = getDist(R1BL, R2BL, R1BR, R2BR);

            // if this is negative then they are not overlap
            if (x > 0)
            {
                //same we can do this by 
                totalArea = x * getDist(R1TL, R2TL, R1TR, R2TR);
            }

            return totalArea;


            //int areaOfSqrA = (R1BR - R1BL) * (R1TR - R1TL);
            //int areaOfSqrB = (R2BR - R2BL) * (R2TR - R2TL);

            //int left = Math.Max(R1BL, R2BL);
            //int right = Math.Min(R1BR, R2BR);
            //int bottom = Math.Max(R1TL, R2TL);
            //int top = Math.Min(R1TR, R2TR);

            ////If overlap
            //int overlap = 0;
            //if (right > left && top > bottom)
            //    overlap = (right - left) * (top - bottom);

            //return areaOfSqrA + areaOfSqrB - overlap;
        }

        public static int getDist(int R1x, int R2x, int R1y, int R2y)
        {
            // get the length of X Axis which is overlapping
            // Why Math.Max(R1x, R2x) because it will start from left to right and overlap will start from Max of these two
            // Why Math.Min(R1y, R2y) because it will start from right to left and overlap will start from min of these two
            // to get the over lap length of x we need minus from right length to left length
            return Math.Min(R1y, R2y) - Math.Max(R1x, R2x);
        }
    }
}
