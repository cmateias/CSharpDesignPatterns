namespace Adapter
{
    public class KitchenStaffAdapter : IWaitingStaff
    {
        private readonly IKitchenStaff _kitchenStaff;

        public KitchenStaffAdapter(IKitchenStaff kitchenStaff)
        {
            _kitchenStaff = kitchenStaff;
        }

        public string Serve()
        {
            return _kitchenStaff.Cook();
        }

        public string TakeOrder()
        {
            return _kitchenStaff.TakeOrder();
        }
    }
}