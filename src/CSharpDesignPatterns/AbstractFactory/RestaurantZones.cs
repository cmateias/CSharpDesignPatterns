using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class RestaurantZones
    {
        public Staff DelegateStaff(string type)
        {
            Staff staff;
            staff = AssignStaff(type);
            staff.Introduce();
            staff.RetrieveOrder();
            staff.ServeOrder();
            staff.GetPayment();
            staff.SayGoodbye();

            return staff;
        }

        protected abstract Staff AssignStaff(string type);
    }
}
