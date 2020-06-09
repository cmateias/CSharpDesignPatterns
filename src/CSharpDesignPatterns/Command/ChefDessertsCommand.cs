namespace Command
{
    public class ChefDessertsCommand : ICommand
    {
        private readonly Chef _chef;

        public ChefDessertsCommand(Chef chef)
        {
            _chef = chef;
        }

        public object Execute()
        {
            return _chef.PreparingDessertsOrder();
        }
    }
}