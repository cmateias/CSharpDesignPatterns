namespace Command
{
    public class WaiterFoodCommand : ICommand
    {
        private readonly Waiter _waiter;

        public WaiterFoodCommand(Waiter waiter)
        {
            _waiter = waiter;
        }

        public object Execute()
        {
            return _waiter.TakeFoodOrder();
        }
    }
}