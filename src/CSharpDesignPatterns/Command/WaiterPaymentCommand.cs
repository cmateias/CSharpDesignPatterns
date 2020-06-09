namespace Command
{
    public class WaiterPaymentCommand : ICommand
    {
        private readonly Waiter _waiter;

        public WaiterPaymentCommand(Waiter waiter)
        {
            _waiter = waiter;
        }

        public object Execute()
        {
            return _waiter.TakePayment();
        }
    }
}