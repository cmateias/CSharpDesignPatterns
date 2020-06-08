using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AdvancedExperience: IStaffExperience
    {
        public string GetExperience()
        {
            return "Advanced";
        }
    }
}
