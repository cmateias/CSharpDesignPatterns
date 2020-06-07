namespace Strategy
{
    public class PartTimeSchedule : IWorkingSchedule
    {
        public string Working()
        {
            return "I only work 3 days a week";
        }
    }
}