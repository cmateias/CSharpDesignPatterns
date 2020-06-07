namespace Strategy
{
    public class ServingTask : IPerformTask
    {
        public string Perform()
        {
            return "I'm ready to take the orders and serve customers";
        }
    }
}