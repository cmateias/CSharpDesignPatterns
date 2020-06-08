using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class SkillsRole
    {
        public virtual string GetDescription()
        {
            return "Unknown skills";
        }

        public abstract string CanDo();
    }
}
