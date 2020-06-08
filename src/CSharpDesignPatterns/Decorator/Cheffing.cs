namespace Decorator
{
    public class Cheffing : SkillsRole
    {
        public override string GetDescription()
        {
            return "I'm a qualified chef";
        }

        public override string CanDo()
        {
            return "I can cook every item on the menu";
        }
    }
}