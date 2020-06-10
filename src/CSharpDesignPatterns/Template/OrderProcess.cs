using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
   public abstract class OrderProcess
    {
        public string PrepareOrder()
        {
            var order = new StringBuilder();
            order.Append(TakeOrder());
            order.Append(GatherIngredients());
            order.Append(Prepare());
            order.Append(Finalise());
            order.Append(ServeOrder());

            return order.ToString();
        }

        private string TakeOrder()
        {
            return "Taking the order to be prepared\n";
        }

        public abstract string GatherIngredients();

        public abstract string Prepare();

        public abstract string Finalise();

        private string ServeOrder()
        {
            return "Serving the order\n";
        }
    }
}
