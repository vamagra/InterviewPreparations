using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Arrays.Important
{
    class PlateformRequiredRailwayStation
    {
        /// <summary>
        /// Given arrival and departure times of all trains that reach a railway station, find the minimum number of platforms required for the railway station so that no train waits.
        //  We are given two arrays which represent arrival and departure times of trains that stop
        //  Examples:
        //  Input:  arr[]  = {9:00,  9:40, 9:50,  11:00, 15:00, 18:00}
        //  dep[]  = {9:10, 12:00, 11:20, 11:30, 19:00, 20:00}
        //  Output: 3
        //  There are at-most three trains at a time(time between 11:00 to 11:20)
        //  </summary>
        //  <param name="arr"></param>
        //  <param name="dep"></param>
        //  <returns></returns>
        public static int CalculatePlateformRequiredRailwayStation(int[] arrival, int[] departure)
        {
            if (arrival == null || departure == null)
            {
                return -1;
            }

            Array.Sort(arrival);
            Array.Sort(departure);

            int i = 1;
            int j = 0;

            int plateformNeeded = 1;
            int maxPlatformCount = 1;

            while (i < arrival.Length && j < arrival.Length)
            {
                if(departure[j] >= arrival[i])
                {
                    plateformNeeded++;
                    i++;

                    maxPlatformCount = Math.Max(plateformNeeded, maxPlatformCount);
                }
                else
                {
                    plateformNeeded--;
                    j++;
                }
            }

            return maxPlatformCount;
        }
    }
}
