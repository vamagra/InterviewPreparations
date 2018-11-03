using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Design
{
    /// <summary>
    /// Given a stream of integers and a window size, calculate the moving average of all 
    /// integers in the sliding window.
    /// </summary>
    class MovingAvergaeDataStream
    {
        Queue<int> queue;
        int windowSize;
        double avg;

        MovingAvergaeDataStream(int size)
        {
            queue = new Queue<int>();
            this.windowSize = size;
        }

        public double next(int val)
        {
            int sum = 0;
            if (queue.Count < windowSize)
            {
                queue.Enqueue(val);
                foreach (int element in queue)
                {
                    sum += element;
                }

                avg = sum / queue.Count;
                return avg;
            }
            else
            {
                int head = queue.Dequeue();
                double minus = head / windowSize;
                double add = val / windowSize;
                queue.Enqueue(val);

                // as we already have avg calculated, we can add the new value average and minus 
                // the head element average from total average
                avg = avg + add - minus;
                return avg;
            }
        }
    }
}
