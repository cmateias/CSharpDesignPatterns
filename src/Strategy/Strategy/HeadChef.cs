namespace Strategy
{
    public class HeadChef : Staff
    {
        public HeadChef()
        {
            performTask = new CookingTask();
            workingSchedule = new FullTimeSchedule();
        }

        public override object ShowDetails()
        {
            return "I'm the head chef";
        }
    }
}