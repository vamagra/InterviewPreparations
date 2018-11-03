using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class ClientClass
    {
        /// <summary>
        /// he following example contains the application entry point that instantiates the BaggageHandler class as well as two instances of 
        /// the ArrivalsMonitor class, and uses the BaggageHandler.BaggageStatus method to add and remove information about arriving flights. In each 
        /// case, the observers receive updates and correctly display baggage 
        /// claim information.
        /// </summary>
        public void Status()
        {
            BaggageHandler provider = new BaggageHandler();
            ArrivalMonitors observer1 = new ArrivalMonitors("BaggageClaimMonitor1");
            ArrivalMonitors observer2 = new ArrivalMonitors("SecurityExit");

            provider.BaggageStatus(712, "Detroit", 3);
            observer1.Subscribe(provider);
            provider.BaggageStatus(712, "Kalamazoo", 3);
            provider.BaggageStatus(400, "New York-Kennedy", 1);
            provider.BaggageStatus(712, "Detroit", 3);
            observer2.Subscribe(provider);
            provider.BaggageStatus(511, "San Francisco", 2);
            provider.BaggageStatus(712);
            observer2.UnSubscribe();
            provider.BaggageStatus(400);
            provider.LastBaggageClaimed();

            // Output
            // The example displays the following output:
            //      Arrivals information from BaggageClaimMonitor1
            //      Detroit                712    3
            //
            //      Arrivals information from BaggageClaimMonitor1
            //      Detroit                712    3
            //      Kalamazoo              712    3
            //
            //      Arrivals information from BaggageClaimMonitor1
            //      Detroit                712    3
            //      Kalamazoo              712    3
            //      New York-Kennedy       400    1
            //
            //      Arrivals information from SecurityExit
            //      Detroit                712    3
            //
            //      Arrivals information from SecurityExit
            //      Detroit                712    3
            //      Kalamazoo              712    3
            //
            //      Arrivals information from SecurityExit
            //      Detroit                712    3
            //      Kalamazoo              712    3
            //      New York-Kennedy       400    1
            //
            //      Arrivals information from BaggageClaimMonitor1
            //      Detroit                712    3
            //      Kalamazoo              712    3
            //      New York-Kennedy       400    1
            //      San Francisco          511    2
            //
            //      Arrivals information from SecurityExit
            //      Detroit                712    3
            //      Kalamazoo              712    3
            //      New York-Kennedy       400    1
            //      San Francisco          511    2
            //
            //      Arrivals information from BaggageClaimMonitor1
            //      New York-Kennedy       400    1
            //      San Francisco          511    2
            //
            //      Arrivals information from SecurityExit
            //      New York-Kennedy       400    1
            //      San Francisco          511    2
            //
            //      Arrivals information from BaggageClaimMonitor1
            //      San Francisco          511    2
        }
    }
}
