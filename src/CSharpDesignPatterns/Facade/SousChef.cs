namespace Facade
{
    public class SousChef
    {
        private readonly string _name;

        public SousChef(string name)
        {
            _name = name;
        }

        public string TakeFoodOrder()
        {
            return $"I'm {_name} and I'm assigned tasks by the Head Chef";
        }


        public string PrepareFood()
        {
            return $"I'm {_name} and I'm preparing starters, mains and desserts";
        }

        public string ClearCookingArea()
        {
            return $"I'm {_name} and I clear the preparation area after each order";
        }
    }
}