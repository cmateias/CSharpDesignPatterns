using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Waiter : Staff
    {
        public Waiter()
        {
            Name = "Jack";
            Experience = "Advanced";
            Role = "Assistant Lead";
        }
    }
}
