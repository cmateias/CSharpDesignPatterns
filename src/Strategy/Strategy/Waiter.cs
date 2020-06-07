namespace Strategy
{
    public class Waiter : Staff
    {
        public Waiter()
        {
            performTask = new ServingTask();
            workingSchedule = new FullTimeSchedule();
        }

        public override object ShowDetails()
        {
            return "I'm the waiter";
        }
    }
}