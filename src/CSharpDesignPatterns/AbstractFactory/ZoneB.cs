namespace AbstractFactory
{
    public class ZoneB : RestaurantZones
    {
        protected override Staff AssignStaff(string type)
        {
            Staff staff = null;
            IStaffDetailsFactory _staffDetailsFactory;
            switch (type)
            {
                case nameof(Waiter):
                    _staffDetailsFactory = new WaiterFactory();
                    staff = new Waiter(_staffDetailsFactory);
                    break;
                case nameof(JuniorWaiter):
                    _staffDetailsFactory = new JuniorWaiterFactory();
                    staff = new JuniorWaiter(_staffDetailsFactory);
                    break;
            }

            return staff;
        }
    }
}