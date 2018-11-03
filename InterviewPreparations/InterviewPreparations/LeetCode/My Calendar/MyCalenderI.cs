using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MyCalenderI
    {
        private static List<int[]> events = new List<int[]>();
        public static bool Book(int start, int end)
        {
            if (start > end)
            {
                return false;
            }

            //It will be overlap, if Max(start of previous Booking, start of new booking) < Min(end of previous booking, end of new booking) 
            foreach(var bookingEvent in events)
            {
                if (Math.Max(bookingEvent[0], start) < Math.Min(bookingEvent[1], end))
                {
                    return false;
                }
            }

            //Add the event in Booking
            events.Add(new int[] { start, end });

            return true;
        }
    }
}
