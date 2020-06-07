namespace Observer
{
    public class HostInfo : IObserver, IInformElement
    {
        private readonly ISubject StaffData;
        private string ExpectedClients;

        public HostInfo(ISubject restaurantData)
        {
            StaffData = restaurantData;
            StaffData.RegisterObserver(this);
        }

        public object Inform()
        {
            return "Tonight we're expecting " + ExpectedClients +
                   " clients, please plan the reservations accordingly";
        }

        public void Update(string expectedClients)
        {
            ExpectedClients = expectedClients;
        }
    }
}