using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class BeginnerExperience:IStaffExperience
    {
        public string GetExperience()
        {
            return "Beginner";
        }
    }
}
