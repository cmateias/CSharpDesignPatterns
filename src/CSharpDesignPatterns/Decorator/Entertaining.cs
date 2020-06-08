namespace Decorator
{
    public class Entertaining : SkillsDecorator
    {
        private readonly SkillsRole _skillsRole;

        public Entertaining(SkillsRole skillsRole)
        {
            _skillsRole = skillsRole;
        }

        public override string GetDescription()
        {
            return _skillsRole.GetDescription() + " and entertainer";
        }

        public override string CanDo()
        {
            return _skillsRole.CanDo() + " and I can also serve flambe steaks";
        }
    }
}