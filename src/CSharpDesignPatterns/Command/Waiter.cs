using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Waiter
    {
        public string TakeDrinksOrder()
        {
            return "Taking drinks order";
        }

        public string TakeFoodOrder()
        {
            return "Taking food order";
        }

        public string TakePayment()
        {
            return "Taking payment";
        }
    }
}
