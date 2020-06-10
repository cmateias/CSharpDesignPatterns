namespace Adapter
{
    public class HeadChef : IKitchenStaff
    {
        public string Cook()
        {
            return "I'm cooking starters, mains and desserts.";
        }

        public string TakeOrder()
        {
            return "I'm taking the food orders from the waiters";
        }
    }
}