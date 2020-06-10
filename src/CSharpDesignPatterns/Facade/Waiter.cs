namespace Facade
{
    public class Waiter
    {
        private readonly string _name;

        public Waiter(string name)
        {
            _name = name;
        }

        public string Serve()
        {
            return $"I'm {_name} and I'm serving the customers";
        }

        public string ClearTable()
        {
            return $"I'm {_name} and I'm clearing the table";
        }
    }
}