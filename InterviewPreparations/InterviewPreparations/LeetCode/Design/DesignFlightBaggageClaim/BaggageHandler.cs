using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    public class BaggageHandler : IObservable<BaggageInfo>
    {
        List<BaggageInfo> flightsBaggageInfo;
        List<IObserver<BaggageInfo>> observers;

        public BaggageHandler()
        {
            flightsBaggageInfo = new List<BaggageInfo>();
            observers = new List<IObserver<BaggageInfo>>();
        }

        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                // Clients that wish to receive updated information call the BaggageHandler.Subscribe method. If the client 
                // has not previously subscribed to notifications, a reference to the client's IObserver<T> implementation is added to the observers collection.
                observers.Add(observer);

                // Provide observer with existing data.
                foreach (var item in flightsBaggageInfo)
                {
                    observer.OnNext(item);
                }
            }

            // The provider's Subscribe method returns an IDisposable implementation that enables observers to stop receiving notifications before the OnCompleted method is called
            return new Unsubscriber<BaggageInfo>(observers, observer);
        }

        /// <summary>
        /// In the second case, the method is passed only a flight number.
        /// </summary>
        /// <param name="flightNo"></param>
        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo, string.Empty, 0);
        }

        /// <summary>
        /// The overloaded BaggageHandler.BaggageStatus method can be called to indicate that baggage from 
        /// a flight either is being unloaded or is no longer being unloaded, In the first case, 
        /// the method is passed a flight number, 
        /// the airport from which the flight originated, and the carousel 
        /// where baggage is being unloaded
        /// </summary>
        /// <param name="flightNo"></param>
        /// <param name="origin"></param>
        /// <param name="carasoul"></param>
        public void BaggageStatus(int flightNo, string origin, int carasoul)
        {
            var flightInfo = new BaggageInfo(flightNo, origin, carasoul);

            // For baggage that is being unloaded, the method checks whether the BaggageInfo information passed to the method exists in the flights collection.
            // If it does not, the method adds the information and calls each observer's OnNext method
            if (carasoul > 0 && !flightsBaggageInfo.Contains(flightInfo))
            {
                // when new flight lands, then add new flight info to the list.
                flightsBaggageInfo.Add(flightInfo);

                // send the notificatio to every observer about the flight
                foreach (var observer in observers)
                {
                    observer.OnNext(flightInfo);
                }
            }
            // For flights whose baggage is no longer being unloaded, the method checks whether information on that flight is stored in the flights collection.
            // If it is, the method calls each observer's OnNext method and removes the BaggageInfo object from the flights collection
            else if (carasoul == 0)
            {
                // Baggage claim is done for that flight
                var flightsToRemove = new List<BaggageInfo>();

                foreach (var flight in flightsBaggageInfo)
                {
                    if (flight.FlightNo == flightInfo.FlightNo)
                    {
                        flightsToRemove.Add(flight);

                        foreach (var observer in observers)
                        {
                            observer.OnNext(flightInfo);
                        }
                    }
                }

                foreach (var flightToRemove in flightsToRemove)
                {
                    flightsToRemove.Remove(flightToRemove);
                }

                flightsToRemove.Clear();
            }
        }

        /// <summary>
        /// When the last flight of the day has landed and its baggage has been processed, the BaggageHandler.LastBaggageClaimed method is called. 
        /// This method calls each observer's OnCompleted method to indicate that all notifications have completed, and then clears the observers collection.
        /// </summary>
        public void LastBaggageClaimed()
        {
            foreach (var observer in observers)
                observer.OnCompleted();

            observers.Clear();
        }
    }

    /// <summary>
    /// When the class is instantiated in the BaggageHandler.Subscribe method, it is passed a reference to 
    /// the observers collection and a reference to the observer that is added to the collection. 
    /// These references are assigned to local variables. When the object's Dispose method is called, 
    /// it checks whether the observer still exists in the observers collection, and, if it does, removes the observer
    /// </summary>
    /// <typeparam name="BaggageInfo"></typeparam>
    internal class Unsubscriber<BaggageInfo> : IDisposable
    {
        private List<IObserver<BaggageInfo>> _observers;
        private IObserver<BaggageInfo> _observer;

        internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
