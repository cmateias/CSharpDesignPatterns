namespace AbstractFactory
{
    public class ZoneA : RestaurantZones
    {
        protected override Staff AssignStaff(string type)
        {
            Staff staff = null;
            IStaffDetailsFactory _staffDetailsFactory;
            switch (type)
            {
                case nameof(HeadWaiter):
                    _staffDetailsFactory = new HeadWaiterFactory();
                    staff = new HeadWaiter(_staffDetailsFactory);
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