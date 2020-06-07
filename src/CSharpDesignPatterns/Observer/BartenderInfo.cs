namespace Observer
{
    public class BartenderInfo : IObserver, IInformElement
    {
        private readonly ISubject StaffData;
        private string ExpectedClients;

        public BartenderInfo(ISubject restaurantData)
        {
            StaffData = restaurantData;
            StaffData.RegisterObserver(this);
        }

        public object Inform()
        {
            return "Tonight we're expecting " + ExpectedClients +
                   " clients, please make sure the bar is stocked";
        }

        public void Update(string expectedClients)
        {
            ExpectedClients = expectedClients;
        }
    }
}