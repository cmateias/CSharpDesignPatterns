namespace State
{
    public class CollectOrderState : IState
    {
        private readonly OrderEPad _orderEPad;

        public CollectOrderState(OrderEPad orderEPad)
        {
            _orderEPad = orderEPad;
        }

        public string Order()
        {
            return "You have already ordered, it's time to collect\n";
        }

        public string ItemRunOut()
        {
            return "You have already ordered and secured the item(s)\n";
        }

        public string Pay()
        {
            return "You have already payed, it's time to collect\n";
        }

        public string CollectOrder()
        {
            _orderEPad.ServeOrder();
            if (_orderEPad.Count > 0)
                _orderEPad.StateOfOrders = new OrderState(_orderEPad);
            else
                _orderEPad.StateOfOrders = new ItemRunOutState(_orderEPad);

            return "It's time to collect\n";
        }
    }
}