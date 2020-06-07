namespace Observer
{
    public class HeadChefInfo : IObserver, IInformElement
    {
        private readonly ISubject StaffData;
        private string ExpectedClients;

        public HeadChefInfo(ISubject restaurantData)
        {
            StaffData = restaurantData;
            StaffData.RegisterObserver(this);
        }

        public object Inform()
        {
            return "Tonight we're expecting " + ExpectedClients +
                   " clients, please ensure that we have enough ingredients to cook for them";
        }

        public void Update(string expectedClients)
        {
            ExpectedClients = expectedClients;
        }
    }
}