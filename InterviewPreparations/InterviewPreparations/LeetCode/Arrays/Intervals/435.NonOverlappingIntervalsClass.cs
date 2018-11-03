using InterviewPreparations.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class NonOverlappingIntervalsClass
    {
        /// <summary>
        //  Given a collection of intervals, find the minimum number of intervals you need to remove to 
        //  make the rest of the intervals non-overlapping.
        //  Note:
        //  You may assume the interval's end point is always bigger than its start point.
        //  Intervals like[1, 2] and[2, 3] have borders "touching" but they don't overlap each other.
        //  Example 1:
        //  Input: [ [1,2], [2,3], [3,4], [1,3] ]
        //  Output: 1
        //  Explanation: [1,3]
        //  can be removed and the rest of intervals are non-overlapping.
        //  Example 2:
        //  Input: [ [1,2], [1,2], [1,2] ]
        //  Output: 2
        //  Explanation: You need to remove two[1, 2] to make the rest of intervals non-overlapping.
        //  Example 3:
        //  Input: [ [1,2], [2,3] ]
        //  Output: 0
        //  Explanation: You don't need to remove any of the intervals since they're already non-overlapping.
        //  </summary>
        //  <param name="intervals"></param>
        //  <returns></returns>
        public int CountNonOverlappingIntervals(Interval[] intervals)
        {
            int n = intervals.Length;

            //Sort the Start End Arrays
            Array.Sort(intervals, new Comparator());

            // Loop through
            int counter = 0;
            int prevIndex = 0;

            for (int currIndex = 1; currIndex < n; currIndex++)
            {
                // if previous interval end is greater than next interval start then there is overlap
                if (intervals[currIndex].start < intervals[prevIndex].end)
                {
                    counter++;

                    // if whole interval is greater than 
                    if(intervals[currIndex].end < intervals[prevIndex].end)
                    {
                        prevIndex = currIndex;
                    }
                }
                else
                {
                    prevIndex = currIndex;
                }
            }

            return counter;
        }

        public class Comparator : IComparer<Interval>
        {
            public int Compare(Interval x, Interval y)
            {
                return x.start - y.start;
            }
        } 
        //public class Interval
        //{
        //    public int start;
        //    public int end;

        //    public Interval()
        //    {
        //        start = 0;
        //        end = 0;
        //    }

        //    public Interval(int x, int y)
        //    {
        //        start = x;
        //        end = y;
        //    }
        //}
    }
}
