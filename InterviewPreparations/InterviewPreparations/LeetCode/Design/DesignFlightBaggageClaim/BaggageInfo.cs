using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    /// A BaggageInfo class provides information about arriving flights and the carousels where baggage from each flight is available for pickup
    /// </summary>
    public class BaggageInfo
    {
        int flightNo;
        int carasoul;
        string origin;

        public BaggageInfo(int flightNo, string location, int carasoul)
        {
            this.flightNo = flightNo;
            this.origin = location;
            this.carasoul = carasoul;
        }

        public int FlightNo
        {
            get
            {
                return this.flightNo;
            }
        }

        public int Carasoul
        {
            get
            {
                return this.carasoul;
            }
        }

        public string Origin
        {
            get
            {
                return this.origin;
            }
        }
    }
}
