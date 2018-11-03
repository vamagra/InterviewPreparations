using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MeetingRoom
    {
        /// <summary>
        /// Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si greater than ei)
        //  determine if a person could attend all meetings.
        //  For example,
        //  Given[[10, 30],[5, 10],[15, 20]],
        //  return false.
        //  </summary>
        //  <returns></returns>
        public static bool IsMeetingRoomAvailable(Interval[] listInterval)
        {
            if (listInterval == null || listInterval.Length == 0)
            {
                return false;
            }

            Array.Sort(listInterval, new Comparator());

            // after sorting the intervals

            // 5 -> 10
            // 10 -> 30
            // 15 -> 20

            for (int i = 0; i < listInterval.Length - 1; i++)
            {
                Console.WriteLine(listInterval[i].start);
            }

            for (int i = 0; i < listInterval.Length - 1; i++)
            {
                // if first meeting end time is greater than next meeting start time
                if (listInterval[i].end > listInterval[i + 1].start)
                {
                    return false;
                }
            }

            return true;
        }

        public class Comparator : IComparer<Interval>
        {
            public int Compare(Interval x, Interval y)
            {
                // This method simply subtracts the second argument's y.start from that of the first x.start. 
                // If the y.start is higher the method returns the difference as a negative
                // amount. If the second argument (y.start) has a lower spend the result will be positive. Finally, 
                // if both spends are the same, the result will be zero. This means that simple subtraction fulfils all 
                // requirements of the interface.
                return x.start - y.start;
            }
        }
    }
}
