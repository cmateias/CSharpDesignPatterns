namespace Factory
{
    public class ZoneB : RestaurantZones
    {
        protected override Staff AssignStaff(string type)
        {
            if (type.Equals(nameof(Waiter)))
                return new Waiter();

            return null;
        }
    }
}