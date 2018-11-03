using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Design
{
    class HTreeConstructionClass
    {
        /// <summary>
        /// An H-tree is a geometric shape that consists of a repeating pattern resembles the letter “H”.
        //  It can be constructed by starting with a line segment of arbitrary length, drawing two segments of the same length at right angles to the first through its endpoints, and continuing in the same vein, reducing(dividing) the length of the line segments drawn at each stage by √2.
        //  Here are some examples of H-trees at different levels of depth:
        //  alt depth = 1
        //  alt depth = 2
        //  alt depth = 3
        //  Write a function drawHTree that constructs an H-tree, given its center(x and y coordinates), a starting length, and depth.Assume that the starting line is parallel to the X-axis.
        //  Use the function drawLine provided to implement your algorithm.In a production code, a drawLine function would render a real line between two points.However, this is not a real production environment, so to make things easier, implement drawLine such that it simply prints its arguments (the print format is left to your discretion).
        //  Analyze the time and space complexity of your algorithm.In your analysis, assume that drawLine's time and space complexities are constant, i.e. O(1).
        //  Constraints:
        //  [time limit] 5000ms
        //  [input] double x
        //  [input] double y
        //  [input] double length
        //  [input] double depth
        //  0 ≤ depth ≤ 10
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="length"></param>
        /// <param name="depth"></param>
        private static void HTree(double x, double y, double depth, double length)
        {
            if (depth <= 0)
                return;

            // draw one H-Tree - draw 3 lines
            var half = length / 2;

            double leftX = x - half;
            double rightX = x + half;
            // Horizontal Line
            DrawLine(leftX, y, rightX, y);

            double topY = y + half;
            double bottomY = y - half;

            // Left Line
            // x1, Y1, X2, Y2
            DrawLine(leftX, topY, leftX, bottomY);

            // Right Line
            DrawLine(rightX, topY, rightX, bottomY);

            // Four recursive calls for four corners
            double nextLength = length / Math.Sqrt(2);
            double nextDepth = depth - 1;

            // go over four corners, LT, clockwise
            // LT
            HTree(leftX, topY, nextDepth, nextLength);

            // RT
            HTree(rightX, topY, nextDepth, nextLength);

            // RB
            HTree(rightX, bottomY, nextDepth, nextLength);

            // LB
            HTree(leftX, bottomY, nextDepth, nextLength);
        }

        private static void DrawLine(double x1, double y1, double x2, double y2)
        {
            // assume that implementation is available
        }
    }
}
