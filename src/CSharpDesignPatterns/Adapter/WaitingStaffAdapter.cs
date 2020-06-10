namespace Adapter
{
    public class WaitingStaffAdapter : IKitchenStaff
    {
        private readonly IWaitingStaff _waitingStaff;

        public WaitingStaffAdapter(IWaitingStaff waitingStaff)
        {
            _waitingStaff = waitingStaff;
        }

        public string Cook()
        {
            return _waitingStaff.Serve();
        }

        public string TakeOrder()
        {
            return _waitingStaff.TakeOrder();
        }
    }
}