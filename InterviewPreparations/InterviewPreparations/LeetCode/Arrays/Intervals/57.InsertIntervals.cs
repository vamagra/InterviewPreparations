using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class InsertIntervals
    {
        /// <summary>
        /// Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
        //  You may assume that the intervals were initially sorted according to their start times.
        //  Example 1:
        //  Input: intervals = [[1, 3], [6,9]], newInterval = [2,5]
        //  Output: [[1,5],[6,9]]
        //  Example 2:
        //  Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
        //  Output: [[1,2],[3,10],[12,16]]
        //  Explanation: Because the new interval[4, 8] overlaps with[3, 5],[6,7],[8,10].
        //  </summary>
        //  <param name="listInterval"></param>
        //  <param name="newInterval"></param>
        //  <returns></returns>
        public static List<Interval> IntervalInsert(List<Interval> listInterval, Interval newInterval)
        {
            //  ___: current interval(i); _ _ _: newInterval

            //1) i.end < newInterval.start，then we can safely add i to result;
            //            newInterval still needs to be compared with latter intervals 

            // in this condition new interval greater than curr interval then add curr interval
            // new interval will continue compare with other intervals further
            // e.g interval (10,20) 
            // new interval (25,50)

            //            | ________ |

            //                           | _ _ _ _ _|

            //         2) i.start > newInterval.end，then we can safely add both to result，

            //    and mark newInterval as null

            //                   | ________ |

            //    | _ _ _ _ _|

            // in this condition new interval less than curr interval then we can both curr and new intervals
            // we can make new interval as null
            // e.g interval (10,20) 
            // new interval (5,8)

            // 3) There is overlap between i and newInterval. We can merge i into newInterval,
            // then use the updated newInterval to compare with latter intervals.

            //     | ________ |

            //         | _ _ _ _ _|

            //          | ________ |

            //      | _ _ _ _ _|

            // reference - https://leetcode.com/problems/insert-interval/discuss/21600/Short-java-code

            if (listInterval == null && listInterval.Count == 0)
            {
                listInterval.Add(newInterval);
                return listInterval;
            }

            List<Interval> result = new List<Interval>();

            foreach (var interval in listInterval)
            {
                //1) i.end < newInterval.start，then we can safely add i to result;
                //            newInterval still needs to be compared with latter intervals
                //            | ________ |
                //                           | _ _ _ _ _|

                if (newInterval == null || interval.end < newInterval.start)
                {
                    result.Add(interval);
                }
                // 2) i.start > newInterval.end，then we can safely add both to result，
                //    and mark newInterval as null

                //                   | ________ |
                //    | _ _ _ _ _|

                else if (interval.start > newInterval.end)
                {
                    result.Add(newInterval);
                    result.Add(interval);
                    newInterval = null;
                }

                // 3) There is overlap between i and newInterval. We can merge i into newInterval,
                // then use the updated newInterval to compare with latter intervals.
                //     | ________ |

                //         | _ _ _ _ _|

                //          | ________ |

                //      | _ _ _ _ _|
                else
                {
                    newInterval.start = Math.Min(interval.start, newInterval.start);
                    newInterval.end = Math.Max(interval.end, newInterval.end);
                }
            }

            // for adding the interval at the end
            if (newInterval != null)
            {
                result.Add(newInterval);
            }

            return result;
        }
    }

    public class Interval
    {
        public int start;
        public int end;

        public Interval()
        {
            start = 0;
            end = 0;
        }

        public Interval(int x, int y)
        {
            start = x;
            end = y;
        }
    }
}
