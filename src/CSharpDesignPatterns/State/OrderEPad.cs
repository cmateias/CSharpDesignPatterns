using System.Text;

namespace State
{
    public class OrderEPad
    {
        private IState _collectOrderState;
        private readonly IState _itemRunOutState;
        private readonly IState _orderState;
        private IState _payState;

        public OrderEPad(int numberOfBurgers)
        {
            _orderState = new OrderState(this);
            _itemRunOutState = new ItemRunOutState(this);
            _payState = new PayState(this);
            _collectOrderState = new CollectOrderState(this);
            Count = numberOfBurgers;
            if (numberOfBurgers > 0)
                StateOfOrders = _orderState;
            else
                StateOfOrders = _itemRunOutState;
        }

        public IState StateOfOrders { get; set; }


        public int Count { get; set; }

        public string Order()
        {
            return StateOfOrders.Order();
        }

        public string ItemRunOut()
        {
            return StateOfOrders.ItemRunOut();
        }

        public string Pay()
        {
            return StateOfOrders.Pay();
        }

        public string CollectOrder()
        {
            return StateOfOrders.CollectOrder();
        }

        public string ServeOrder()
        {
            if (Count != 0) Count -= 1;
            return "Here is your order, enjoy it\n";
        }

        public string OrderStateInfo()
        {
            var state = new StringBuilder();

            state.Append("Number of burgers: " + Count);
            state.Append("\nOrder is currently: " + StateOfOrders.ToString());

            return state.ToString();
        }
    }
}