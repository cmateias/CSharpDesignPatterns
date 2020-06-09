namespace Command
{
    public class WaiterDrinksCommand : ICommand
    {
        private readonly Waiter _waiter;

        public WaiterDrinksCommand(Waiter waiter)
        {
            _waiter = waiter;
        }

        public object Execute()
        {
            return _waiter.TakeDrinksOrder();
        }
    }
}