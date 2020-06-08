using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WorldClassExperience:IStaffExperience
    {
        public string GetExperience()
        {
            return "World Class";
        }
    }
}
