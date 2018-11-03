using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class MeetingRoomII
    {
        /// <summary>
        //  Given an array of meeting time intervals consisting of start and end times 
        //  [[s1,e1],[s2,e2],...] (si < ei), find the minimum number of conference rooms required.
        //  For example,
        //  Given[[0, 30],[5, 10],[15, 20]],
        //  return 2.
        //  </summary>
        //  <param name="listInterval"></param>
        //  <returns></returns>
        //  10:00 - 10:30
        //  10:05 - 10:10
        //  10:15 - 10:20
        public static int CountConfRoomMeetingIntervals(List<Interval> listInterval)
        {
            if (listInterval == null || listInterval.Count == 0)
            {
                return -1;
            }

            int[] start = new int[listInterval.Count];
            int[] end = new int[listInterval.Count];

            for (int i = 0; i < listInterval.Count; i++)
            {
                start[i] = listInterval[i].start;
            }

            for (int i = 0; i < listInterval.Count; i++)
            {
                end[i] = listInterval[i].end;
            }

            Array.Sort(start);
            Array.Sort(end);

            int endPosition = 0;
            int resultCount = 0;

            for (int i = 0; i < listInterval.Count; i++)
            {
                if(start[i] < end[endPosition])
                {
                    resultCount++;
                }
                else
                {
                    endPosition++;
                }
            }

            return resultCount;
        }
    }
}
