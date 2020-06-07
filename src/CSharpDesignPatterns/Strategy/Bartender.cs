namespace Strategy
{
    public class Bartender : Staff
    {
        public Bartender()
        {
            performTask = new BarTask();
            workingSchedule = new FullTimeSchedule();
        }

        public override object ShowDetails()
        {
            return "I'm the bartender";
        }
    }
}