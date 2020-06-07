namespace Strategy
{
    public class Host : Staff
    {
        public Host()
        {
            performTask = new HostingTask();
            workingSchedule = new FullTimeSchedule();
        }

        public override object ShowDetails()
        {
            return "I'm the host";
        }
    }
}