using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Bartending : SkillsDecorator
    {
        private readonly SkillsRole _skillsRole;

        public Bartending(SkillsRole skillsRole)
        {
            _skillsRole = skillsRole;
        }

        public override string GetDescription()
        {
            return _skillsRole.GetDescription() + " and bartender";
        }

        public override string CanDo()
        {
            return _skillsRole.CanDo() + " and I can also prepare cocktails";
        }
    }
}
