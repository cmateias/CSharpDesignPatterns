namespace Command
{
    public class ChefMainsCommand : ICommand
    {
        private readonly Chef _chef;

        public ChefMainsCommand(Chef chef)
        {
            _chef = chef;
        }

        public object Execute()
        {
            return _chef.PreparingMainsOrder();
        }
    }
}