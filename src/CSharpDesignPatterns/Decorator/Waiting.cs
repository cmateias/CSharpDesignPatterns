namespace Decorator
{
    public class Waiting : SkillsRole
    {
        public override string GetDescription()
        {
            return "I'm a qualified waiter";
        }

        public override string CanDo()
        {
            return "I can take orders and serve the customers";
        }
    }
}