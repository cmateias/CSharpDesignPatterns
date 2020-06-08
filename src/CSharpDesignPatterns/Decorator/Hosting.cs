using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Hosting : SkillsRole
    {
        public override string GetDescription()
        {
            return "I'm a qualified host";
        }

        public override string CanDo()
        {
            return "I can take bookings and welcome the customers";
        }
    }
}
