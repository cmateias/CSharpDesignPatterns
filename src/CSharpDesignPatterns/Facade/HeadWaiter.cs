namespace Facade
{
    public class HeadWaiter
    {
        private readonly string _name;

        public HeadWaiter(string name)
        {
            _name = name;
        }

        public string TakeOrder()
        {
            return $"I'm {_name} and I'm taking clients orders";
        }

        public string TakePayment()
        {
            return $"I'm {_name} and I'm taking clients payments";
        }
    }
}