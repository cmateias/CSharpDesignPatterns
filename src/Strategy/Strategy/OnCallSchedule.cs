namespace Strategy
{
    public class OnCallSchedule : IWorkingSchedule
    {
        public string Working()
        {
            return "I only work if I'm needed, usually for cover";
        }
    }
}