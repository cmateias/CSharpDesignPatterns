namespace Observer
{
    public class WaiterInfo : IObserver, IInformElement
    {
        private readonly ISubject StaffData;
        private string ExpectedClients;

        public WaiterInfo(ISubject restaurantData)
        {
            StaffData = restaurantData;
            StaffData.RegisterObserver(this);
        }

        public object Inform()
        {
            return "Tonight we're expecting " + ExpectedClients +
                   " clients, please arrange the tables according to the bookings";
        }

        public void Update(string expectedClients)
        {
            ExpectedClients = expectedClients;
        }
    }
}