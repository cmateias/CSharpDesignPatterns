namespace Strategy
{
    public class FullTimeSchedule : IWorkingSchedule
    {
        public string Working()
        {
            return "I work 5 days a week";
        }
    }
}