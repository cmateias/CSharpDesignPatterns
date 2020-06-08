using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Singing : SkillsDecorator
    {
        private readonly SkillsRole _skillsRole;

        public Singing(SkillsRole skillsRole)
        {
            _skillsRole = skillsRole;
        }

        public override string GetDescription()
        {
            return _skillsRole.GetDescription() + " and singer";
        }

        public override string CanDo()
        {
            return _skillsRole.CanDo() + " and I can also sing classic music";
        }
    }
}
