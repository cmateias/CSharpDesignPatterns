namespace Command
{
    public class ChefStartersCommand : ICommand
    {
        private readonly Chef _chef;

        public ChefStartersCommand(Chef chef)
        {
            _chef = chef;
        }

        public object Execute()
        {
            return _chef.PreparingStartersOrder();
        }
    }
}