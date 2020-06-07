using System.Collections;

namespace Observer
{
    public class RestaurantData : ISubject
    {
        private readonly ArrayList observers;
        private string ExpectedClients;

        public RestaurantData()
        {
            observers = new ArrayList();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            var i = observers.IndexOf(o);
            if (i > -1) observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers) observer.Update(ExpectedClients);
        }

        public void ExpectedClientsUpdated()
        {
            NotifyObserver();
        }

        public void SetExpectedClients(string expectedClients)
        {
            ExpectedClients = expectedClients;
            ExpectedClientsUpdated();
        }
    }
}