namespace Adapter
{
    public class HeadWaiter : IWaitingStaff
    {
        public string Serve()
        {
            return "I'm serving the customers.";
        }

        public string TakeOrder()
        {
            return "I'm taking customers orders.";
        }
    }
}