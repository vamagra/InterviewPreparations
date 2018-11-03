using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    public class ArrivalMonitors : IObserver<BaggageInfo>
    {
        List<string> flightInfos = new List<string>();
        IDisposable cancellation;
        string name;
        private string fmt = "{0,-20} {1,5}  {2, 3}";
        public ArrivalMonitors(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("The observer must be assigned a name.");

            this.name = name;
        }
        /// <summary>
        /// The ArrivalsMonitor class includes the Subscribe and Unsubscribe methods. The Subscribe method enables the class to save the IDisposable implementation returned by 
        /// the call to Subscribe to a private variable
        /// </summary>
        /// <param name="provider"></param>
        public void Subscribe(BaggageHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }
        /// <summary>
        /// The Unsubscribe method enables the class to unsubscribe from notifications by calling the provider's Dispose implementation
        /// </summary>
        public void UnSubscribe()
        {
            cancellation.Dispose();
            flightInfos.Clear();
        }

        /// <summary>
        /// The method works with a private, sorted, generic List<T> object that maintains information about the airports of origin for arriving flights and the carousels 
        /// on which their baggage is available. If the BaggageHandler class reports a new flight arrival, the OnNext method implementation adds information about that flight 
        /// to the list. If the BaggageHandler class reports that the flight's baggage has been unloaded, the OnNext method removes that flight from the list. Whenever a change is 
        /// made, the list is sorted and displayed to the console.
        /// </summary>
        /// <param name="info"></param>
        public void OnNext(BaggageInfo info)
        {
            bool updated = false;
            if (info.Carasoul == 0)
            {
                var flightsToRemove = new List<string>();
                string flightNo = string.Format("{0,5}", info.FlightNo);

                foreach (var flightInfo in flightInfos)
                {
                    if (flightInfo.Substring(21, 5).Equals(flightNo))
                    {
                        flightsToRemove.Add(flightInfo);
                        updated = true;
                    }
                }

                foreach (var flightToRemove in flightsToRemove)
                    flightInfos.Remove(flightToRemove);

                flightsToRemove.Clear();
            }
            else
            {
                // Add flight if it does not exist in the collection.
                string flighInfo = string.Format(fmt, info.Origin, info.FlightNo, info.Carasoul);
                if (!flightInfos.Contains(flighInfo))
                {
                    flightInfos.Add(flighInfo);
                    updated = true;
                }
            }

            if (updated)
            {
                flightInfos.Sort();
                Console.WriteLine("Arrivals information from {0}", name);
                foreach (var flightInfo in flightInfos)
                    Console.WriteLine(flightInfo);

                Console.WriteLine();
            }
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            flightInfos.Clear();
        }
    }
}
