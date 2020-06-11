namespace State
{
    public class PayState : IState
    {
        private readonly OrderEPad _orderEPad;

        public PayState(OrderEPad orderEPad)
        {
            _orderEPad = orderEPad;
        }

        public string Order()
        {
            return "You have already ordered, it's time to pay\n";
        }

        public string ItemRunOut()
        {
            return "You have already ordered, so there are still some items left\n";
        }

        public string Pay()
        {
            _orderEPad.StateOfOrders = new CollectOrderState(_orderEPad);
            return "Paying....going to collection instructions\n";
        }

        public string CollectOrder()
        {
            return "The payment needs to be made first\n";
        }
    }
}