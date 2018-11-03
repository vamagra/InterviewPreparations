using InterviewPreparations.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MergeIntervals
    {
        /// <summary>
        //  Given a collection of intervals, merge all overlapping intervals.
        //  For example,
        //  Given [1, 3],[2, 6],[8, 10],[15, 18],
        //  return [1,6],[8,10],[15,18].
        //  </summary>
        //  <param name="initervals"></param>
        //  <returns></returns>
        public IList<Interval> MergeInterval(IList<Interval> initervals)
        {
            int n = initervals.Count;

            int[] starts = new int[n];
            int[] ends = new int[n];

            //assign start and end interval in individual arrays
            for (int i = 0; i < n; i++)
            {
                starts[i] = initervals[i].start;
                ends[i] = initervals[i].end;
            }

            // Idea is quite simple here
            // two interval can only be merged if first interval end time is greater than 
            // next meeting start time

            //Sort the Start End Arrays
            Array.Sort(starts);
            Array.Sort(ends);

            // Loop through
            List<Interval> listResult = new List<Interval>();

            for (int end = 0, start = 0; end < n; end++)
            {
                // keep moving to next interval untill we found next interval start time is greater than previous end time
                if (end == n - 1 || starts[end + 1] > ends[end])
                {
                    listResult.Add(new Interval(starts[start], ends[end]));
                    start = end + 1;
                }
            }

            return listResult;
        }
    }

    //internal class Interval
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
