namespace Strategy
{
    public class SousChef : Staff
    {
        public SousChef()
        {
            performTask = new CookingTask();
            workingSchedule = new PartTimeSchedule();
        }

        public override object ShowDetails()
        {
            return "I'm a sous chef";
        }
    }
}