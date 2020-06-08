namespace AbstractFactory
{
    public class TeamLeadRole : IStaffRole
    {
        public string GetRole()
        {
            return "Team Lead";
        }
    }
}