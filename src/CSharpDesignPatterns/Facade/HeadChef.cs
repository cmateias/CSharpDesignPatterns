namespace Facade
{
    public class HeadChef
    {
        private readonly string _name;

        public HeadChef(string name)
        {
            _name = name;
        }

        public string DelegateTask()
        {
            return $"I'm {_name} and I'm assigning the tasks to sous chefs";
        }

        public string FinalChecks()
        {
            return $"I'm {_name} and I'm checking the food before being served";
        }
    }
}