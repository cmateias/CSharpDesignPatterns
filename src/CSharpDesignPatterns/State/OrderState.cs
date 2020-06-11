namespace State
{
    public class OrderState : IState
    {
        private readonly OrderEPad _orderEPad;

        public OrderState(OrderEPad orderEPad)
        {
            _orderEPad = orderEPad;
        }

        public string Order()
        {
            var output = "Ordering...";
            if (_orderEPad.Count < 1)
            {
                _orderEPad.StateOfOrders = new ItemRunOutState(_orderEPad);
                output += "there are no more items to order\n";
            }
            else
            {
                _orderEPad.StateOfOrders = new PayState(_orderEPad);
                output += "going to payment\n";
            }

            return output;
        }

        public string ItemRunOut()
        {
            return "You haven't started the order yet so we're not sure if there are any items left \n";
        }

        public string Pay()
        {
            return "You haven't ordered yet, so you cannot pay\n";
        }

        public string CollectOrder()
        {
            return "You haven't ordered yet, so there is nothing to collect\n";
        }
    }
}