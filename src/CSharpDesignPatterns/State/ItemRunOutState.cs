using System;

namespace State
{
    public class ItemRunOutState : IState
    {
        private OrderEPad _orderEPad;

        public ItemRunOutState(OrderEPad orderEPad)
        {
            _orderEPad = orderEPad;
        }

        public string Order()
        {
            return "Sorry you can't place an order! Sold out!\n";
        }

        public string ItemRunOut()
        {
            return "Sorry, we ran out of items! Sold out!\n";
        }

        public string Pay()
        {
            return "Sorry there's nothing to pay for! Sold out!\n";
        }

        public string CollectOrder()
        {
            return "Sorry there's nothing to collect! Sold out!\n";
        }
    }
}