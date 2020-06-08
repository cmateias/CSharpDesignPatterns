namespace Factory
{
    public class ZoneA : RestaurantZones
    {
        protected override Staff AssignStaff(string type)
        {
            if (type.Equals(nameof(HeadWaiter)))
                return new HeadWaiter();
            if (type.Equals(nameof(JuniorWaiter)))
                return new JuniorWaiter();

            return null;
        }
    }
}